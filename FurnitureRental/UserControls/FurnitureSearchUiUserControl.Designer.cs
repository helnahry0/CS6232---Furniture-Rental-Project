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
            FurnSearchPanel = new Panel();
            ClearButton = new Button();
            AddDescriptionLabel = new Label();
            DescriptionLabel = new Label();
            FurnitureDataGridView = new DataGridView();
            FurnSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FurnitureDataGridView).BeginInit();
            SuspendLayout();
            // 
            // FurnitureSearchLabel
            // 
            FurnitureSearchLabel.AutoSize = true;
            FurnitureSearchLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            FurnitureSearchLabel.Location = new Point(18, 24);
            FurnitureSearchLabel.Name = "FurnitureSearchLabel";
            FurnitureSearchLabel.Size = new Size(115, 20);
            FurnitureSearchLabel.TabIndex = 0;
            FurnitureSearchLabel.Text = "Furniture Search";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(19, 85);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(67, 15);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category   :";
            // 
            // StyleLabel
            // 
            StyleLabel.AutoSize = true;
            StyleLabel.Location = new Point(18, 127);
            StyleLabel.Name = "StyleLabel";
            StyleLabel.Size = new Size(65, 15);
            StyleLabel.TabIndex = 2;
            StyleLabel.Text = "Style          :";
            // 
            // FurnitureIdLabel
            // 
            FurnitureIdLabel.AutoSize = true;
            FurnitureIdLabel.Location = new Point(15, 170);
            FurnitureIdLabel.Name = "FurnitureIdLabel";
            FurnitureIdLabel.Size = new Size(72, 15);
            FurnitureIdLabel.TabIndex = 3;
            FurnitureIdLabel.Text = "Furniture ID:";
            // 
            // FurnitureNameLabel
            // 
            FurnitureNameLabel.AutoSize = true;
            FurnitureNameLabel.Location = new Point(18, 218);
            FurnitureNameLabel.Name = "FurnitureNameLabel";
            FurnitureNameLabel.Size = new Size(93, 15);
            FurnitureNameLabel.TabIndex = 4;
            FurnitureNameLabel.Text = "Furniture Name:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(132, 85);
            CategoryComboBox.Margin = new Padding(3, 2, 3, 2);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(189, 23);
            CategoryComboBox.TabIndex = 5;
            // 
            // StyleComboBox
            // 
            StyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StyleComboBox.FormattingEnabled = true;
            StyleComboBox.Location = new Point(132, 127);
            StyleComboBox.Margin = new Padding(3, 2, 3, 2);
            StyleComboBox.Name = "StyleComboBox";
            StyleComboBox.Size = new Size(189, 23);
            StyleComboBox.TabIndex = 6;
            // 
            // FurnitureIdTextBox
            // 
            FurnitureIdTextBox.Location = new Point(132, 170);
            FurnitureIdTextBox.Margin = new Padding(3, 2, 3, 2);
            FurnitureIdTextBox.Name = "FurnitureIdTextBox";
            FurnitureIdTextBox.Size = new Size(189, 23);
            FurnitureIdTextBox.TabIndex = 7;
            // 
            // FurnitureNameTextBox
            // 
            FurnitureNameTextBox.Location = new Point(143, 218);
            FurnitureNameTextBox.Margin = new Padding(3, 2, 3, 2);
            FurnitureNameTextBox.Name = "FurnitureNameTextBox";
            FurnitureNameTextBox.ReadOnly = true;
            FurnitureNameTextBox.Size = new Size(175, 23);
            FurnitureNameTextBox.TabIndex = 8;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(19, 339);
            SearchButton.Margin = new Padding(3, 2, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(82, 22);
            SearchButton.TabIndex = 9;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Location = new Point(205, 339);
            AddToCartButton.Margin = new Padding(3, 2, 3, 2);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(130, 22);
            AddToCartButton.TabIndex = 10;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // FurnSearchPanel
            // 
            FurnSearchPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FurnSearchPanel.Controls.Add(ClearButton);
            FurnSearchPanel.Controls.Add(CategoryComboBox);
            FurnSearchPanel.Controls.Add(AddDescriptionLabel);
            FurnSearchPanel.Controls.Add(FurnitureNameLabel);
            FurnSearchPanel.Controls.Add(DescriptionLabel);
            FurnSearchPanel.Controls.Add(StyleComboBox);
            FurnSearchPanel.Controls.Add(FurnitureNameTextBox);
            FurnSearchPanel.Controls.Add(FurnitureIdLabel);
            FurnSearchPanel.Controls.Add(AddToCartButton);
            FurnSearchPanel.Controls.Add(FurnitureIdTextBox);
            FurnSearchPanel.Controls.Add(FurnitureSearchLabel);
            FurnSearchPanel.Controls.Add(StyleLabel);
            FurnSearchPanel.Controls.Add(SearchButton);
            FurnSearchPanel.Controls.Add(CategoryLabel);
            FurnSearchPanel.Location = new Point(24, 20);
            FurnSearchPanel.Margin = new Padding(3, 2, 3, 2);
            FurnSearchPanel.Name = "FurnSearchPanel";
            FurnSearchPanel.Size = new Size(375, 448);
            FurnSearchPanel.TabIndex = 1;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(114, 339);
            ClearButton.Margin = new Padding(3, 2, 3, 2);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(82, 22);
            ClearButton.TabIndex = 13;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // AddDescriptionLabel
            // 
            AddDescriptionLabel.AutoSize = true;
            AddDescriptionLabel.Location = new Point(24, 278);
            AddDescriptionLabel.Name = "AddDescriptionLabel";
            AddDescriptionLabel.Size = new Size(136, 15);
            AddDescriptionLabel.TabIndex = 12;
            AddDescriptionLabel.Text = "description of item here.";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(18, 258);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(76, 15);
            DescriptionLabel.TabIndex = 11;
            DescriptionLabel.Text = "Description : ";
            // 
            // FurnitureDataGridView
            // 
            FurnitureDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FurnitureDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FurnitureDataGridView.Location = new Point(450, 0);
            FurnitureDataGridView.Margin = new Padding(3, 2, 3, 2);
            FurnitureDataGridView.Name = "FurnitureDataGridView";
            FurnitureDataGridView.RowHeadersWidth = 51;
            FurnitureDataGridView.Size = new Size(751, 484);
            FurnitureDataGridView.TabIndex = 0;
            // 
            // FurnitureSearchUiUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(FurnitureDataGridView);
            Controls.Add(FurnSearchPanel);
            Name = "FurnitureSearchUiUserControl";
            Size = new Size(1201, 484);
            FurnSearchPanel.ResumeLayout(false);
            FurnSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FurnitureDataGridView).EndInit();
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
        private DataGridView FurnitureDataGridView;
        private Label AddDescriptionLabel;
        private Label DescriptionLabel;
        private Button ClearButton;
        private Panel FurnSearchPanel;
    }
}
