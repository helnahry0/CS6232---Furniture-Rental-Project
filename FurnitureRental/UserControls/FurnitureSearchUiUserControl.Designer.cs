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
            ClearButton = new Button();
            AddDescriptionLabel = new Label();
            DescriptionLabel = new Label();
            FurnitureDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FurnitureDataGridView).BeginInit();
            SuspendLayout();
            // 
            // FurnitureSearchLabel
            // 
            FurnitureSearchLabel.AutoSize = true;
            FurnitureSearchLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            FurnitureSearchLabel.Location = new Point(25, 18);
            FurnitureSearchLabel.Name = "FurnitureSearchLabel";
            FurnitureSearchLabel.Size = new Size(139, 25);
            FurnitureSearchLabel.TabIndex = 0;
            FurnitureSearchLabel.Text = "Furniture Search";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(26, 100);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(84, 20);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category   :";
            // 
            // StyleLabel
            // 
            StyleLabel.AutoSize = true;
            StyleLabel.Location = new Point(25, 156);
            StyleLabel.Name = "StyleLabel";
            StyleLabel.Size = new Size(84, 20);
            StyleLabel.TabIndex = 2;
            StyleLabel.Text = "Style          :";
            // 
            // FurnitureIdLabel
            // 
            FurnitureIdLabel.AutoSize = true;
            FurnitureIdLabel.Location = new Point(21, 213);
            FurnitureIdLabel.Name = "FurnitureIdLabel";
            FurnitureIdLabel.Size = new Size(89, 20);
            FurnitureIdLabel.TabIndex = 3;
            FurnitureIdLabel.Text = "Furniture ID:";
            // 
            // FurnitureNameLabel
            // 
            FurnitureNameLabel.AutoSize = true;
            FurnitureNameLabel.Location = new Point(24, 277);
            FurnitureNameLabel.Name = "FurnitureNameLabel";
            FurnitureNameLabel.Size = new Size(114, 20);
            FurnitureNameLabel.TabIndex = 4;
            FurnitureNameLabel.Text = "Furniture Name:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(155, 100);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(215, 28);
            CategoryComboBox.TabIndex = 5;
            // 
            // StyleComboBox
            // 
            StyleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StyleComboBox.FormattingEnabled = true;
            StyleComboBox.Location = new Point(155, 156);
            StyleComboBox.Name = "StyleComboBox";
            StyleComboBox.Size = new Size(215, 28);
            StyleComboBox.TabIndex = 6;
            // 
            // FurnitureIdTextBox
            // 
            FurnitureIdTextBox.Location = new Point(155, 213);
            FurnitureIdTextBox.Name = "FurnitureIdTextBox";
            FurnitureIdTextBox.Size = new Size(215, 27);
            FurnitureIdTextBox.TabIndex = 7;
            // 
            // FurnitureNameTextBox
            // 
            FurnitureNameTextBox.Location = new Point(167, 277);
            FurnitureNameTextBox.Name = "FurnitureNameTextBox";
            FurnitureNameTextBox.ReadOnly = true;
            FurnitureNameTextBox.Size = new Size(199, 27);
            FurnitureNameTextBox.TabIndex = 8;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(26, 439);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 9;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Location = new Point(238, 439);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(148, 29);
            AddToCartButton.TabIndex = 10;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(24, 19);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(ClearButton);
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
            splitContainer1.Panel2.Controls.Add(FurnitureDataGridView);
            splitContainer1.Size = new Size(1177, 497);
            splitContainer1.SplitterDistance = 408;
            splitContainer1.TabIndex = 11;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(134, 439);
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
            AddDescriptionLabel.Location = new Point(31, 357);
            AddDescriptionLabel.Name = "AddDescriptionLabel";
            AddDescriptionLabel.Size = new Size(171, 20);
            AddDescriptionLabel.TabIndex = 12;
            AddDescriptionLabel.Text = "description of item here.";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(24, 331);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(96, 20);
            DescriptionLabel.TabIndex = 11;
            DescriptionLabel.Text = "Description : ";
            // 
            // FurnitureDataGridView
            // 
            FurnitureDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FurnitureDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FurnitureDataGridView.Dock = DockStyle.Fill;
            FurnitureDataGridView.Location = new Point(0, 0);
            FurnitureDataGridView.Name = "FurnitureDataGridView";
            FurnitureDataGridView.RowHeadersWidth = 51;
            FurnitureDataGridView.Size = new Size(765, 497);
            FurnitureDataGridView.TabIndex = 0;
            // 
            // FurnitureSearchUiUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FurnitureSearchUiUserControl";
            Size = new Size(1236, 551);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
        private SplitContainer splitContainer1;
        private DataGridView FurnitureDataGridView;
        private Label AddDescriptionLabel;
        private Label DescriptionLabel;
        private Button ClearButton;
    }
}
