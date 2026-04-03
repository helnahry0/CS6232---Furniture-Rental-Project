using FurnitureRental.Controller;

namespace FurnitureRental.View
{
    /// <summary>
    /// Provides the main menu screen after employee login.
    /// </summary>
    public partial class MainMenuForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainMenuForm"/> class.
        /// </summary>
        public MainMenuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the form load event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Employee != null)
            {
                lblUsername.Text =
                    $"Logged in as: {CurrentUser.Employee.FirstName} {CurrentUser.Employee.LastName} - Employee ID: {CurrentUser.Employee.EmployeeId}";

                LoadSearchMemberUserControl();
            }
            else
            {
                lblUsername.Text = "Not logged in";
            }
        }

        /// <summary>
        /// Loads the search member control into the tab.
        /// </summary>
        private void LoadSearchMemberUserControl()
        {
            var searchControl = new UserControls.SearchMemberUserControl
            {
                Dock = DockStyle.Fill
            };

            SearchMember.Controls.Clear();
            SearchMember.Controls.Add(searchControl);
        }

        /// <summary>
        /// Handles logout.
        /// </summary>
        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentUser.Logout();
            DialogResult = DialogResult.Retry;
            Close();
        }

        /// <summary>
        /// Handles closing the main form.
        /// </summary>
        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.Retry)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}