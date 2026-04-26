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
            FurnitureSearchLabel.Location = new Point(21, 32);
            FurnitureSearchLabel.Name = "FurnitureSearchLabel";
            FurnitureSearchLabel.Size = new Size(139, 25);
            FurnitureSearchLabel.TabIndex = 0;
            FurnitureSearchLabel.Text = "Furniture Search";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(22, 113);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(84, 20);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category   :";
            // 
            // StyleLabel
            // 
            StyleLabel.AutoSize = true;
            StyleLabel.Location = new Point(21, 169);
            StyleLabel.Name = "StyleLabel";
            StyleLabel.Size = new Size(84, 20);
            StyleLabel.TabIndex = 2;
            StyleLabel.Text = "Style          :";
            // 
            // FurnitureIdLabel
            // 
            FurnitureIdLabel.AutoSize = true;
            FurnitureIdLabel.Location = new Point(17, 226);
            FurnitureIdLabel.Name = "FurnitureIdLabel";
            FurnitureIdLabel.Size = new Size(89, 20);
            FurnitureIdLabel.TabIndex = 3;
            FurnitureIdLabel.Text = "Furniture ID:";
            // 
            // FurnitureNameLabel
            // 
            FurnitureNameLabel.AutoSize = true;
            FurnitureNameLabel.Location = new Point(20, 290);
            FurnitureNameLabel.Name = "FurnitureNameLabel";
            FurnitureNameLabel.Size = new Size(114, 20);
            FurnitureNameLabel.TabIndex = 4;
            FurnitureNameLabel.Text = "Furniture Name:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(151, 113);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(215, 28);
            CategoryComboBox.TabIndex = 5;
            // 
            // StyleComboBox
            // 
            StyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StyleComboBox.FormattingEnabled = true;
            StyleComboBox.Location = new Point(151, 169);
            StyleComboBox.Name = "StyleComboBox";
            StyleComboBox.Size = new Size(215, 28);
            StyleComboBox.TabIndex = 6;
            // 
            // FurnitureIdTextBox
            // 
            FurnitureIdTextBox.Location = new Point(151, 226);
            FurnitureIdTextBox.Name = "FurnitureIdTextBox";
            FurnitureIdTextBox.Size = new Size(215, 27);
            FurnitureIdTextBox.TabIndex = 7;
            // 
            // FurnitureNameTextBox
            // 
            FurnitureNameTextBox.Location = new Point(163, 290);
            FurnitureNameTextBox.Name = "FurnitureNameTextBox";
            FurnitureNameTextBox.ReadOnly = true;
            FurnitureNameTextBox.Size = new Size(199, 27);
            FurnitureNameTextBox.TabIndex = 8;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(22, 452);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 9;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Location = new Point(234, 452);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(149, 29);
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
            FurnSearchPanel.Location = new Point(27, 26);
            FurnSearchPanel.Name = "FurnSearchPanel";
            FurnSearchPanel.Size = new Size(439, 597);
            FurnSearchPanel.TabIndex = 1;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(130, 452);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 29);
            ClearButton.TabIndex = 13;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // AddDescriptionLabel
            // 
            AddDescriptionLabel.AutoSize = true;
            AddDescriptionLabel.Location = new Point(27, 370);
            AddDescriptionLabel.Name = "AddDescriptionLabel";
            AddDescriptionLabel.Size = new Size(171, 20);
            AddDescriptionLabel.TabIndex = 12;
            AddDescriptionLabel.Text = "description of item here.";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(20, 344);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(96, 20);
            DescriptionLabel.TabIndex = 11;
            DescriptionLabel.Text = "Description : ";
            // 
            // FurnitureDataGridView
            // 
            FurnitureDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FurnitureDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FurnitureDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FurnitureDataGridView.Location = new Point(472, 26);
            FurnitureDataGridView.Name = "FurnitureDataGridView";
            FurnitureDataGridView.RowHeadersWidth = 51;
            FurnitureDataGridView.Size = new Size(752, 597);
            FurnitureDataGridView.TabIndex = 0;
            // 
            // FurnitureSearchUiUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(FurnitureDataGridView);
            Controls.Add(FurnSearchPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FurnitureSearchUiUserControl";
            Size = new Size(1237, 645);
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
