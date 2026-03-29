namespace FurnitureRental.View
{
    partial class CreateMemberForm
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
            createMemberUserControl1 = new FurnitureRental.UserControls.CreateMemberUserControl();
            SuspendLayout();
            // 
            // createMemberUserControl1
            // 
            createMemberUserControl1.AutoSize = true;
            createMemberUserControl1.Dock = DockStyle.Fill;
            createMemberUserControl1.Location = new Point(0, 0);
            createMemberUserControl1.Name = "createMemberUserControl1";
            createMemberUserControl1.Size = new Size(800, 508);
            createMemberUserControl1.TabIndex = 0;
            // 
            // CreateMemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 508);
            Controls.Add(createMemberUserControl1);
            Name = "CreateMemberForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateMemberForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControls.CreateMemberUserControl createMemberUserControl1;
    }
}