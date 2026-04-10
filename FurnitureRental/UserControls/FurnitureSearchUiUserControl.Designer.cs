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
            FurnitureSearchLabel.Location = new Point(40, 67);
            FurnitureSearchLabel.Name = "FurnitureSearchLabel";
            FurnitureSearchLabel.Size = new Size(115, 20);
            FurnitureSearchLabel.TabIndex = 0;
            FurnitureSearchLabel.Text = "Furniture Search";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(39, 105);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(84, 20);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category   :";
            // 
            // StyleLabel
            // 
            StyleLabel.AutoSize = true;
            StyleLabel.Location = new Point(39, 151);
            StyleLabel.Name = "StyleLabel";
            StyleLabel.Size = new Size(84, 20);
            StyleLabel.TabIndex = 2;
            StyleLabel.Text = "Style          :";
            // 
            // FurnitureIdLabel
            // 
            FurnitureIdLabel.AutoSize = true;
            FurnitureIdLabel.Location = new Point(34, 197);
            FurnitureIdLabel.Name = "FurnitureIdLabel";
            FurnitureIdLabel.Size = new Size(89, 20);
            FurnitureIdLabel.TabIndex = 3;
            FurnitureIdLabel.Text = "Furniture ID:";
            // 
            // FurnitureNameLabel
            // 
            FurnitureNameLabel.AutoSize = true;
            FurnitureNameLabel.Location = new Point(34, 272);
            FurnitureNameLabel.Name = "FurnitureNameLabel";
            FurnitureNameLabel.Size = new Size(114, 20);
            FurnitureNameLabel.TabIndex = 4;
            FurnitureNameLabel.Text = "Furniture Name:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(129, 105);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(215, 28);
            CategoryComboBox.TabIndex = 5;
            // 
            // StyleComboBox
            // 
            StyleComboBox.FormattingEnabled = true;
            StyleComboBox.Location = new Point(129, 151);
            StyleComboBox.Name = "StyleComboBox";
            StyleComboBox.Size = new Size(215, 28);
            StyleComboBox.TabIndex = 6;
            // 
            // FurnitureIdTextBox
            // 
            FurnitureIdTextBox.Location = new Point(129, 197);
            FurnitureIdTextBox.Name = "FurnitureIdTextBox";
            FurnitureIdTextBox.Size = new Size(215, 27);
            FurnitureIdTextBox.TabIndex = 7;
            // 
            // FurnitureNameTextBox
            // 
            FurnitureNameTextBox.Location = new Point(154, 269);
            FurnitureNameTextBox.Name = "FurnitureNameTextBox";
            FurnitureNameTextBox.Size = new Size(190, 27);
            FurnitureNameTextBox.TabIndex = 8;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(58, 350);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 9;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Location = new Point(196, 350);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(148, 29);
            AddToCartButton.TabIndex = 10;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(24, 19);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
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
            splitContainer1.Size = new Size(1209, 497);
            splitContainer1.SplitterDistance = 453;
            splitContainer1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(708, 460);
            dataGridView1.TabIndex = 0;
            // 
            // FurnitureSearchUiUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FurnitureSearchUiUserControl";
            Size = new Size(1257, 551);
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
    }
}
