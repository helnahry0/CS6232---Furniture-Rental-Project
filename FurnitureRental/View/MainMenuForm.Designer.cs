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
            searchMemberUserControl1 = new FurnitureRental.UserControls.SearchMemberUserControl();
            CreateMember = new TabPage();
            createMemberUserControl1 = new FurnitureRental.UserControls.CreateMemberUserControl();
            FurnitureSearch = new TabPage();
            Cart = new TabPage();
            Returns = new TabPage();
            label1 = new Label();
            lblUsername = new Label();
            lnkLogout = new LinkLabel();
            tabControlMainform.SuspendLayout();
            SearchMember.SuspendLayout();
            CreateMember.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMainform
            // 
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
            tabControlMainform.Size = new Size(891, 588);
            tabControlMainform.TabIndex = 0;
            // 
            // SearchMember
            // 
            SearchMember.Controls.Add(searchMemberUserControl1);
            SearchMember.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchMember.Location = new Point(4, 34);
            SearchMember.Margin = new Padding(3, 4, 3, 4);
            SearchMember.Name = "SearchMember";
            SearchMember.Padding = new Padding(3, 4, 3, 4);
            SearchMember.Size = new Size(883, 550);
            SearchMember.TabIndex = 0;
            SearchMember.Text = "Search Member";
            SearchMember.UseVisualStyleBackColor = true;
            // 
            // searchMemberUserControl1
            // 
            searchMemberUserControl1.Location = new Point(11, 8);
            searchMemberUserControl1.Margin = new Padding(3, 5, 3, 5);
            searchMemberUserControl1.Name = "searchMemberUserControl1";
            searchMemberUserControl1.Size = new Size(590, 388);
            searchMemberUserControl1.TabIndex = 0;
            // 
            // CreateMember
            // 
            CreateMember.Controls.Add(createMemberUserControl1);
            CreateMember.Location = new Point(4, 34);
            CreateMember.Margin = new Padding(3, 4, 3, 4);
            CreateMember.Name = "CreateMember";
            CreateMember.Padding = new Padding(3, 4, 3, 4);
            CreateMember.Size = new Size(883, 550);
            CreateMember.TabIndex = 4;
            CreateMember.Text = "Create Member";
            CreateMember.UseVisualStyleBackColor = true;
            // 
            // createMemberUserControl1
            // 
            createMemberUserControl1.Dock = DockStyle.Fill;
            createMemberUserControl1.Location = new Point(3, 4);
            createMemberUserControl1.Name = "createMemberUserControl1";
            createMemberUserControl1.Size = new Size(877, 542);
            createMemberUserControl1.TabIndex = 0;
            // 
            // FurnitureSearch
            // 
            FurnitureSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FurnitureSearch.Location = new Point(4, 34);
            FurnitureSearch.Margin = new Padding(3, 4, 3, 4);
            FurnitureSearch.Name = "FurnitureSearch";
            FurnitureSearch.Padding = new Padding(3, 4, 3, 4);
            FurnitureSearch.Size = new Size(192, 62);
            FurnitureSearch.TabIndex = 1;
            FurnitureSearch.Text = "Furniture Search";
            FurnitureSearch.UseVisualStyleBackColor = true;
            // 
            // Cart
            // 
            Cart.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cart.Location = new Point(4, 34);
            Cart.Margin = new Padding(3, 4, 3, 4);
            Cart.Name = "Cart";
            Cart.Size = new Size(192, 62);
            Cart.TabIndex = 2;
            Cart.Text = "Cart";
            Cart.UseVisualStyleBackColor = true;
            // 
            // Returns
            // 
            Returns.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Returns.Location = new Point(4, 34);
            Returns.Margin = new Padding(3, 4, 3, 4);
            Returns.Name = "Returns";
            Returns.Size = new Size(192, 62);
            Returns.TabIndex = 3;
            Returns.Text = "Returns";
            Returns.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(429, 41);
            label1.TabIndex = 2;
            label1.Text = "FURNITURE RENTAL SYSTEM";
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
            lnkLogout.AutoSize = true;
            lnkLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkLogout.Location = new Point(824, 28);
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
            ClientSize = new Size(914, 716);
            Controls.Add(lnkLogout);
            Controls.Add(lblUsername);
            Controls.Add(label1);
            Controls.Add(tabControlMainform);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenuForm";
            FormClosed += MainMenuForm_FormClosed;
            tabControlMainform.ResumeLayout(false);
            SearchMember.ResumeLayout(false);
            CreateMember.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlMainform;
        private TabPage SearchMember;
        private TabPage FurnitureSearch;
        private Label label1;
        private Label lblUsername;
        private LinkLabel lnkLogout;
        private TabPage Cart;
        private TabPage Returns;
        private TabPage CreateMember;
        private UserControls.SearchMemberUserControl searchMemberUserControl1;
        private UserControls.CreateMemberUserControl createMemberUserControl1;
    }
}