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
            Cart = new TabPage();
            Returns = new TabPage();
            lblMainForm = new Label();
            lblUsername = new Label();
            lnkLogout = new LinkLabel();
            tabControlMainform.SuspendLayout();
            CreateMember.SuspendLayout();
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
            tabControlMainform.Location = new Point(12, 86);
            tabControlMainform.Name = "tabControlMainform";
            tabControlMainform.SelectedIndex = 0;
            tabControlMainform.Size = new Size(862, 517);
            tabControlMainform.TabIndex = 0;
            // 
            // SearchMember
            // 
            SearchMember.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchMember.Location = new Point(4, 29);
            SearchMember.Name = "SearchMember";
            SearchMember.Padding = new Padding(3, 3, 3, 3);
            SearchMember.Size = new Size(854, 484);
            SearchMember.TabIndex = 0;
            SearchMember.Text = "Search Member";
            SearchMember.UseVisualStyleBackColor = true;
            // 
            // CreateMember
            // 
            CreateMember.Controls.Add(createMemberUserControl1);
            CreateMember.Location = new Point(4, 29);
            CreateMember.Name = "CreateMember";
            CreateMember.Padding = new Padding(3, 3, 3, 3);
            CreateMember.Size = new Size(854, 484);
            CreateMember.TabIndex = 4;
            CreateMember.Text = "Create Member";
            CreateMember.UseVisualStyleBackColor = true;
            // 
            // createMemberUserControl1
            // 
            createMemberUserControl1.Dock = DockStyle.Fill;
            createMemberUserControl1.Location = new Point(3, 3);
            createMemberUserControl1.Margin = new Padding(3, 2, 3, 2);
            createMemberUserControl1.Name = "createMemberUserControl1";
            createMemberUserControl1.Size = new Size(848, 478);
            createMemberUserControl1.TabIndex = 0;
            // 
            // FurnitureSearch
            // 
            FurnitureSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FurnitureSearch.Location = new Point(4, 29);
            FurnitureSearch.Name = "FurnitureSearch";
            FurnitureSearch.Padding = new Padding(3, 3, 3, 3);
            FurnitureSearch.Size = new Size(854, 484);
            FurnitureSearch.TabIndex = 1;
            FurnitureSearch.Text = "Furniture Search";
            FurnitureSearch.UseVisualStyleBackColor = true;
            // 
            // Cart
            // 
            Cart.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cart.Location = new Point(4, 29);
            Cart.Name = "Cart";
            Cart.Size = new Size(854, 484);
            Cart.TabIndex = 2;
            Cart.Text = "Cart";
            Cart.UseVisualStyleBackColor = true;
            // 
            // Returns
            // 
            Returns.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Returns.Location = new Point(4, 29);
            Returns.Name = "Returns";
            Returns.Size = new Size(854, 484);
            Returns.TabIndex = 3;
            Returns.Text = "Returns";
            Returns.UseVisualStyleBackColor = true;
            // 
            // lblMainForm
            // 
            lblMainForm.AutoSize = true;
            lblMainForm.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMainForm.Location = new Point(17, 9);
            lblMainForm.Name = "lblMainForm";
            lblMainForm.Size = new Size(340, 32);
            lblMainForm.TabIndex = 2;
            lblMainForm.Text = "FURNITURE RENTAL SYSTEM";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(26, 50);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(77, 15);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Logged in as:";
            // 
            // lnkLogout
            // 
            lnkLogout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lnkLogout.AutoSize = true;
            lnkLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkLogout.Location = new Point(815, 22);
            lnkLogout.Name = "lnkLogout";
            lnkLogout.Size = new Size(51, 17);
            lnkLogout.TabIndex = 4;
            lnkLogout.TabStop = true;
            lnkLogout.Text = "Logout";
            lnkLogout.LinkClicked += lnkLogout_LinkClicked;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 613);
            Controls.Add(lnkLogout);
            Controls.Add(lblUsername);
            Controls.Add(lblMainForm);
            Controls.Add(tabControlMainform);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Furniture Rental";
            FormClosed += MainMenuForm_FormClosed;
            tabControlMainform.ResumeLayout(false);
            CreateMember.ResumeLayout(false);
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
    }
}