namespace FurnitureRental.View
{
    partial class MainMenuForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlMainform = new TabControl();
            SearchMember = new TabPage();
            CreateMember = new TabPage();
            createMemberUserControl1 = new FurnitureRental.UserControls.CreateMemberUserControl();
            FurnitureSearch = new TabPage();
            furnitureSearchUiUserControl1 = new FurnitureRental.UserControls.FurnitureSearchUiUserControl();
            Cart = new TabPage();
            rentalCartUserControl1 = new FurnitureRental.UserControls.RentalCartUserControl();
            Returns = new TabPage();
            lblMainForm = new Label();
            lblUsername = new Label();
            lnkLogout = new LinkLabel();
            tabControlMainform.SuspendLayout();
            CreateMember.SuspendLayout();
            FurnitureSearch.SuspendLayout();
            Cart.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMainform
            // 
            tabControlMainform.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMainform.Controls.Add(SearchMember);
            tabControlMainform.Controls.Add(CreateMember);
            tabControlMainform.Controls.Add(FurnitureSearch);
            tabControlMainform.Controls.Add(Cart);
            tabControlMainform.Controls.Add(Returns);
            tabControlMainform.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlMainform.Location = new Point(14, 115);
            tabControlMainform.Margin = new Padding(3, 4, 3, 4);
            tabControlMainform.Name = "tabControlMainform";
            tabControlMainform.SelectedIndex = 0;
            tabControlMainform.Size = new Size(1217, 767);
            tabControlMainform.TabIndex = 0;
            // 
            // SearchMember
            // 
            SearchMember.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchMember.Location = new Point(4, 34);
            SearchMember.Margin = new Padding(3, 4, 3, 4);
            SearchMember.Name = "SearchMember";
            SearchMember.Padding = new Padding(3, 5, 3, 5);
            SearchMember.Size = new Size(1209, 729);
            SearchMember.TabIndex = 0;
            SearchMember.Text = "Search Member";
            SearchMember.UseVisualStyleBackColor = true;
            // 
            // CreateMember
            // 
            CreateMember.Controls.Add(createMemberUserControl1);
            CreateMember.Location = new Point(4, 29);
            CreateMember.Margin = new Padding(3, 4, 3, 4);
            CreateMember.Name = "CreateMember";
            CreateMember.Padding = new Padding(3, 4, 3, 4);
            CreateMember.Size = new Size(192, 67);
            CreateMember.TabIndex = 4;
            CreateMember.Text = "Create Member";
            CreateMember.UseVisualStyleBackColor = true;
            // 
            // createMemberUserControl1
            // 
            createMemberUserControl1.Dock = DockStyle.Fill;
            createMemberUserControl1.Location = new Point(3, 4);
            createMemberUserControl1.Name = "createMemberUserControl1";
            createMemberUserControl1.Size = new Size(186, 59);
            createMemberUserControl1.TabIndex = 0;
            // 
            // FurnitureSearch
            // 
            FurnitureSearch.Controls.Add(furnitureSearchUiUserControl1);
            FurnitureSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FurnitureSearch.Location = new Point(4, 34);
            FurnitureSearch.Margin = new Padding(3, 4, 3, 4);
            FurnitureSearch.Name = "FurnitureSearch";
            FurnitureSearch.Padding = new Padding(3, 4, 3, 4);
            FurnitureSearch.Size = new Size(1209, 729);
            FurnitureSearch.TabIndex = 1;
            FurnitureSearch.Text = "Furniture Search";
            FurnitureSearch.UseVisualStyleBackColor = true;
            // 
            // furnitureSearchUiUserControl1
            // 
            furnitureSearchUiUserControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            furnitureSearchUiUserControl1.Location = new Point(3, 4);
            furnitureSearchUiUserControl1.Margin = new Padding(3, 4, 3, 4);
            furnitureSearchUiUserControl1.Name = "furnitureSearchUiUserControl1";
            furnitureSearchUiUserControl1.Size = new Size(1203, 721);
            furnitureSearchUiUserControl1.TabIndex = 0;
            // 
            // Cart
            // 
            Cart.Controls.Add(rentalCartUserControl1);
            Cart.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cart.Location = new Point(4, 29);
            Cart.Margin = new Padding(3, 4, 3, 4);
            Cart.Name = "Cart";
            Cart.Size = new Size(192, 67);
            Cart.TabIndex = 2;
            Cart.Text = "Cart";
            Cart.UseVisualStyleBackColor = true;
            // 
            // rentalCartUserControl1
            // 
            rentalCartUserControl1.Location = new Point(94, 15);
            rentalCartUserControl1.Margin = new Padding(3, 5, 3, 5);
            rentalCartUserControl1.Name = "rentalCartUserControl1";
            rentalCartUserControl1.Size = new Size(730, 704);
            rentalCartUserControl1.TabIndex = 0;
            // 
            // Returns
            // 
            Returns.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Returns.Location = new Point(4, 29);
            Returns.Margin = new Padding(3, 4, 3, 4);
            Returns.Name = "Returns";
            Returns.Size = new Size(192, 67);
            Returns.TabIndex = 3;
            Returns.Text = "Returns";
            Returns.UseVisualStyleBackColor = true;
            // 
            // lblMainForm
            // 
            lblMainForm.AutoSize = true;
            lblMainForm.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMainForm.Location = new Point(19, 12);
            lblMainForm.Name = "lblMainForm";
            lblMainForm.Size = new Size(429, 41);
            lblMainForm.TabIndex = 2;
            lblMainForm.Text = "FURNITURE RENTAL SYSTEM";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(30, 67);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 20);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Logged in as:";
            // 
            // lnkLogout
            // 
            lnkLogout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lnkLogout.AutoSize = true;
            lnkLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkLogout.Location = new Point(931, 29);
            lnkLogout.Name = "lnkLogout";
            lnkLogout.Size = new Size(64, 23);
            lnkLogout.TabIndex = 4;
            lnkLogout.TabStop = true;
            lnkLogout.Text = "Logout";
            lnkLogout.LinkClicked += lnkLogout_LinkClicked;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 895);
            Controls.Add(lnkLogout);
            Controls.Add(lblUsername);
            Controls.Add(lblMainForm);
            Controls.Add(tabControlMainform);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Furniture Rental";
            FormClosing += MainMenuForm_FormClosing;
            Load += MainMenuForm_Load;
            tabControlMainform.ResumeLayout(false);
            CreateMember.ResumeLayout(false);
            FurnitureSearch.ResumeLayout(false);
            Cart.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlMainform;
        private TabPage SearchMember;
        private TabPage FurnitureSearch;
        private Label lblMainForm;
        private Label lblUsername;
        private LinkLabel lnkLogout;
        private TabPage Cart;
        private TabPage Returns;
        private TabPage CreateMember;
        private UserControls.CreateMemberUserControl createMemberUserControl1;
        private UserControls.RentalCartUserControl rentalCartUserControl1;
        private UserControls.FurnitureSearchUiUserControl furnitureSearchUiUserControl1;
    }
}