namespace FurnitureRental.View
{
    public partial class MainMenuForm : Form
    {

        public MainMenuForm()
        {
            InitializeComponent();
            lblUsername.Text =
                    $"Logged in as: {CurrentUser.Employee.FirstName} {CurrentUser.Employee.LastName} - " +
                    $"Employee ID: {CurrentUser.Employee.EmployeeId}";

            LoadSearchMemberUserControl();
        }

        private void LoadSearchMemberUserControl()
        {
            var searchControl = new UserControls.SearchMemberUserControl
            {
                Dock = DockStyle.Fill
            };

            SearchMember.Controls.Clear();
            SearchMember.Controls.Add(searchControl);
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
