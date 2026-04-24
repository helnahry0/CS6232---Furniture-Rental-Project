using FurnitureRental.Controller;
using FurnitureRental.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void SetupReportGrid()
        {
            dgvReport.AutoGenerateColumns = false;
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
    }
}
