using FurnitureRental.Controller;
using FurnitureRental.Model;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace FurnitureRental.UserControls
{
    public partial class AdminReportUserControl : UserControl
    {
        private readonly ReportController _reportController = new ReportController();

        public AdminReportUserControl()
        {
            InitializeComponent();
            SetupReportGrid();
        }

        /// <summary>
        /// Setup DataGrid for the Most Popular Furniture report.
        /// </summary>
        /// <returns> None.</returns>
        private void SetupReportGrid()
        {
            dgvReport.AutoGenerateColumns = false;
            dgvReport.AllowUserToAddRows = false;
            dgvReport.ReadOnly = true;
            dgvReport.Columns.Clear();

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Furniture ID",
                DataPropertyName = "FurnitureId"
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Category",
                DataPropertyName = "CategoryName"
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Furniture Name",
                DataPropertyName = "FurnitureName",
                Width = 150
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Rental Tx Count",
                DataPropertyName = "RentalTransactionCount"
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Rentals",
                DataPropertyName = "TotalRentalTransactions"
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Rental %",
                DataPropertyName = "RentalPercentage",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Age 18-29 %",
                DataPropertyName = "Age18To29Percentage",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvReport.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Outside 18-29 %",
                DataPropertyName = "Outside18To29Percentage",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });
        }

        /// <summary>
        /// Generate the Most Popular Furniture report based on the start data
        /// and end date and populates the data to the DataGridView Report.
        /// </summary>
        /// <returns> None.</returns>
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be after end date.");
                return;
            }

            List<PopularFurnitureReportItem> reportData =
                _reportController.GetMostPopularFurnitureDuringDates(startDate, endDate);

            dgvReport.DataSource = null;
            dgvReport.DataSource = reportData;

            if (reportData.Count == 0)
            {
                MessageBox.Show("No report data found for the selected date range.");
            }
        }

        /// <summary>
        /// Exports the Most Popular Furniture report to Excel file.
        /// </summary>
        /// <returns> None.</returns>
        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No report data to export.");
                return;
            }

            using SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV File (*.csv)|*.csv";
            saveDialog.Title = "Save Report as CSV";
            saveDialog.FileName = "PopularFurnitureReport.csv";

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Most Popular Furniture Report");
                sb.AppendLine($"Start Date,\"{dtpStartDate.Value:yyyy-MM-dd}\"");
                sb.AppendLine($"End Date,\"{dtpEndDate.Value:yyyy-MM-dd}\"");
                sb.AppendLine($"Generated,\"{DateTime.Now:g}\"");
                sb.AppendLine();

                // CSV Report Headers
                for (int i = 0; i < dgvReport.Columns.Count; i++)
                {
                    sb.Append(dgvReport.Columns[i].HeaderText);

                    if (i < dgvReport.Columns.Count - 1)
                        sb.Append(",");
                }

                sb.AppendLine();

                // Add Rows
                foreach (DataGridViewRow row in dgvReport.Rows)
                {
                    if (row.IsNewRow) continue;

                    for (int i = 0; i < dgvReport.Columns.Count; i++)
                    {
                        string value = row.Cells[i].Value?.ToString() ?? "";

                        // Escape commas
                        value = $"\"{value.Replace("\"", "\"\"")}\"";

                        sb.Append(value);

                        if (i < dgvReport.Columns.Count - 1)
                            sb.Append(",");
                    }

                    sb.AppendLine();
                }

                File.WriteAllText(saveDialog.FileName, sb.ToString());

                MessageBox.Show("CSV exported successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed.\n" + ex.Message);
            }
        }

        /// <summary>
        /// Exports the Most Popular Furniture report to PDF file.
        /// </summary>
        /// <returns> None.</returns>
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No report data to export.");
                return;
            }

            using SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF File (*.pdf)|*.pdf";
            saveDialog.Title = "Save Report as PDF";
            saveDialog.FileName = "PopularFurnitureReport.pdf";

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.A4.Rotate(), 10f, 10f, 20f, 20f);

                PdfWriter.GetInstance(document, new FileStream(saveDialog.FileName, FileMode.Create));

                document.Open();

                // Title
                iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                Paragraph title = new Paragraph("Most Popular Furniture Report", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 15f;

                document.Add(title);

                //Add the selected date range (Start Date and End Date)
                document.Add(new Paragraph($"Start Date: {dtpStartDate.Value:yyyy-MM-dd}"));
                document.Add(new Paragraph($"End Date: {dtpEndDate.Value:yyyy-MM-dd}"));
                // Date
                document.Add(new Paragraph($"Generated: {DateTime.Now:g}"));
                document.Add(new Paragraph(" "));

                // Table
                PdfPTable table = new PdfPTable(dgvReport.Columns.Count);
                table.WidthPercentage = 100;

                // Headers
                foreach (DataGridViewColumn column in dgvReport.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                    {
                        BackgroundColor = BaseColor.LIGHT_GRAY
                    };

                    table.AddCell(cell);
                }

                // Rows
                foreach (DataGridViewRow row in dgvReport.Rows)
                {
                    if (row.IsNewRow) continue;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(cell.Value?.ToString() ?? "");
                    }
                }

                document.Add(table);

                document.Close();

                MessageBox.Show("PDF exported successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed.\n" + ex.Message);
            }
        }
    }
}
