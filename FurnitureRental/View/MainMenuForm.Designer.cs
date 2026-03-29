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
            MemberSearch = new TabPage();
            FurnitureSearch = new TabPage();
            Cart = new TabPage();
            Returns = new TabPage();
            label1 = new Label();
            lblUsername = new Label();
            lnkLogout = new LinkLabel();
            tabControlMainform.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMainform
            // 
            tabControlMainform.Controls.Add(MemberSearch);
            tabControlMainform.Controls.Add(FurnitureSearch);
            tabControlMainform.Controls.Add(Cart);
            tabControlMainform.Controls.Add(Returns);
            tabControlMainform.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlMainform.Location = new Point(12, 86);
            tabControlMainform.Name = "tabControlMainform";
            tabControlMainform.SelectedIndex = 0;
            tabControlMainform.Size = new Size(780, 352);
            tabControlMainform.TabIndex = 0;
            // 
            // MemberSearch
            // 
            MemberSearch.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MemberSearch.Location = new Point(4, 29);
            MemberSearch.Name = "MemberSearch";
            MemberSearch.Padding = new Padding(3);
            MemberSearch.Size = new Size(772, 319);
            MemberSearch.TabIndex = 0;
            MemberSearch.Text = "Member Search";
            MemberSearch.UseVisualStyleBackColor = true;
            // 
            // FurnitureSearch
            // 
            FurnitureSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FurnitureSearch.Location = new Point(4, 29);
            FurnitureSearch.Name = "FurnitureSearch";
            FurnitureSearch.Padding = new Padding(3);
            FurnitureSearch.Size = new Size(772, 319);
            FurnitureSearch.TabIndex = 1;
            FurnitureSearch.Text = "Furniture Search";
            FurnitureSearch.UseVisualStyleBackColor = true;
            // 
            // Cart
            // 
            Cart.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cart.Location = new Point(4, 29);
            Cart.Name = "Cart";
            Cart.Size = new Size(772, 319);
            Cart.TabIndex = 2;
            Cart.Text = "Cart";
            Cart.UseVisualStyleBackColor = true;
            // 
            // Returns
            // 
            Returns.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Returns.Location = new Point(4, 29);
            Returns.Name = "Returns";
            Returns.Size = new Size(772, 319);
            Returns.TabIndex = 3;
            Returns.Text = "Returns";
            Returns.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(340, 32);
            label1.TabIndex = 2;
            label1.Text = "FURNITURE RENTAL SYSTEM";
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
            lnkLogout.AutoSize = true;
            lnkLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkLogout.Location = new Point(721, 21);
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
            ClientSize = new Size(800, 450);
            Controls.Add(lnkLogout);
            Controls.Add(lblUsername);
            Controls.Add(label1);
            Controls.Add(tabControlMainform);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            FormClosed += MainMenuForm_FormClosed;
            tabControlMainform.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlMainform;
        private TabPage MemberSearch;
        private TabPage FurnitureSearch;
        private Label label1;
        private Label lblUsername;
        private LinkLabel lnkLogout;
        private TabPage Cart;
        private TabPage Returns;
    }
}