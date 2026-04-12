namespace FurnitureRental.UserControls
{
    partial class FurnitureSearchUiUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FurnitureSearchLabel = new Label();
            CategoryLabel = new Label();
            StyleLabel = new Label();
            FurnitureIdLabel = new Label();
            FurnitureNameLabel = new Label();
            CategoryComboBox = new ComboBox();
            StyleComboBox = new ComboBox();
            FurnitureIdTextBox = new TextBox();
            FurnitureNameTextBox = new TextBox();
            SearchButton = new Button();
            AddToCartButton = new Button();
            splitContainer1 = new SplitContainer();
            AddDescriptionLabel = new Label();
            DescriptionLabel = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // FurnitureSearchLabel
            // 
            FurnitureSearchLabel.AutoSize = true;
            FurnitureSearchLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            FurnitureSearchLabel.Location = new Point(22, 14);
            FurnitureSearchLabel.Name = "FurnitureSearchLabel";
            FurnitureSearchLabel.Size = new Size(115, 20);
            FurnitureSearchLabel.TabIndex = 0;
            FurnitureSearchLabel.Text = "Furniture Search";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(34, 75);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(67, 15);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category   :";
            // 
            // StyleLabel
            // 
            StyleLabel.AutoSize = true;
            StyleLabel.Location = new Point(34, 117);
            StyleLabel.Name = "StyleLabel";
            StyleLabel.Size = new Size(65, 15);
            StyleLabel.TabIndex = 2;
            StyleLabel.Text = "Style          :";
            // 
            // FurnitureIdLabel
            // 
            FurnitureIdLabel.AutoSize = true;
            FurnitureIdLabel.Location = new Point(30, 160);
            FurnitureIdLabel.Name = "FurnitureIdLabel";
            FurnitureIdLabel.Size = new Size(72, 15);
            FurnitureIdLabel.TabIndex = 3;
            FurnitureIdLabel.Text = "Furniture ID:";
            // 
            // FurnitureNameLabel
            // 
            FurnitureNameLabel.AutoSize = true;
            FurnitureNameLabel.Location = new Point(22, 210);
            FurnitureNameLabel.Name = "FurnitureNameLabel";
            FurnitureNameLabel.Size = new Size(93, 15);
            FurnitureNameLabel.TabIndex = 4;
            FurnitureNameLabel.Text = "Furniture Name:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(113, 75);
            CategoryComboBox.Margin = new Padding(3, 2, 3, 2);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(189, 23);
            CategoryComboBox.TabIndex = 5;
            // 
            // StyleComboBox
            // 
            StyleComboBox.FormattingEnabled = true;
            StyleComboBox.Location = new Point(113, 117);
            StyleComboBox.Margin = new Padding(3, 2, 3, 2);
            StyleComboBox.Name = "StyleComboBox";
            StyleComboBox.Size = new Size(189, 23);
            StyleComboBox.TabIndex = 6;
            // 
            // FurnitureIdTextBox
            // 
            FurnitureIdTextBox.Location = new Point(113, 160);
            FurnitureIdTextBox.Margin = new Padding(3, 2, 3, 2);
            FurnitureIdTextBox.Name = "FurnitureIdTextBox";
            FurnitureIdTextBox.Size = new Size(189, 23);
            FurnitureIdTextBox.TabIndex = 7;
            // 
            // FurnitureNameTextBox
            // 
            FurnitureNameTextBox.Location = new Point(127, 208);
            FurnitureNameTextBox.Margin = new Padding(3, 2, 3, 2);
            FurnitureNameTextBox.Name = "FurnitureNameTextBox";
            FurnitureNameTextBox.ReadOnly = true;
            FurnitureNameTextBox.Size = new Size(175, 23);
            FurnitureNameTextBox.TabIndex = 8;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(33, 329);
            SearchButton.Margin = new Padding(3, 2, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(82, 22);
            SearchButton.TabIndex = 9;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Location = new Point(154, 329);
            AddToCartButton.Margin = new Padding(3, 2, 3, 2);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(130, 22);
            AddToCartButton.TabIndex = 10;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(21, 14);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(AddDescriptionLabel);
            splitContainer1.Panel1.Controls.Add(DescriptionLabel);
            splitContainer1.Panel1.Controls.Add(FurnitureNameTextBox);
            splitContainer1.Panel1.Controls.Add(AddToCartButton);
            splitContainer1.Panel1.Controls.Add(FurnitureSearchLabel);
            splitContainer1.Panel1.Controls.Add(SearchButton);
            splitContainer1.Panel1.Controls.Add(CategoryLabel);
            splitContainer1.Panel1.Controls.Add(StyleLabel);
            splitContainer1.Panel1.Controls.Add(FurnitureIdTextBox);
            splitContainer1.Panel1.Controls.Add(FurnitureIdLabel);
            splitContainer1.Panel1.Controls.Add(StyleComboBox);
            splitContainer1.Panel1.Controls.Add(FurnitureNameLabel);
            splitContainer1.Panel1.Controls.Add(CategoryComboBox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(869, 373);
            splitContainer1.SplitterDistance = 348;
            splitContainer1.TabIndex = 11;
            // 
            // AddDescriptionLabel
            // 
            AddDescriptionLabel.AutoSize = true;
            AddDescriptionLabel.Location = new Point(27, 268);
            AddDescriptionLabel.Name = "AddDescriptionLabel";
            AddDescriptionLabel.Size = new Size(136, 15);
            AddDescriptionLabel.TabIndex = 12;
            AddDescriptionLabel.Text = "description of item here.";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(21, 248);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(76, 15);
            DescriptionLabel.TabIndex = 11;
            DescriptionLabel.Text = "Description : ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(517, 373);
            dataGridView1.TabIndex = 0;
            // 
            // FurnitureSearchUiUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "FurnitureSearchUiUserControl";
            Size = new Size(921, 413);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label FurnitureSearchLabel;
        private Label CategoryLabel;
        private Label StyleLabel;
        private Label FurnitureIdLabel;
        private Label FurnitureNameLabel;
        private ComboBox CategoryComboBox;
        private ComboBox StyleComboBox;
        private TextBox FurnitureIdTextBox;
        private TextBox FurnitureNameTextBox;
        private Button SearchButton;
        private Button AddToCartButton;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private Label AddDescriptionLabel;
        private Label DescriptionLabel;
    }
}
