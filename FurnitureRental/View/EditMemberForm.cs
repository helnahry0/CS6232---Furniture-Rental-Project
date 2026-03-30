using FurnitureRental.DAL;
using FurnitureRental.Model;

namespace FurnitureRental.View
{
    public partial class EditMemberForm : Form
    {
        private readonly int _memberId;
        private readonly MemberDbDal _memberDal = new MemberDbDal();

        public EditMemberForm(int memberId)
        {
            InitializeComponent();
            _memberId = memberId;

            this.Load += EditMemberForm_Load;
        }

        private void EditMemberForm_Load(object sender, EventArgs e)
        {
            LoadStates();
            LoadGenders();

            Member? member = _memberDal.GetMemberById(_memberId);

            if (member == null)
            {
                MessageBox.Show("Member not found.");
                this.Close();
                return;
            }

            txtMemberId.Text = member.MemberId.ToString();
            txtFirstName.Text = member.FirstName;
            txtLastName.Text = member.LastName;
            cboGender.SelectedItem = member.Sex;
            dtpDOB.Value = member.Dob;
            txtPhone.Text = member.Phone;
            txtAddress1.Text = member.Address1;
            txtAddress2.Text = member.Address2;
            txtCity.Text = member.City;
            cboState.SelectedItem = member.State;
            txtZip.Text = member.Zip;
        }

        private void LoadGenders()
        {
            cboGender.Items.AddRange(new[]
            {
                "Male",
                "Female",
                "Other"
            });
        }

        private void LoadStates()
        {
            cboState.Items.AddRange(new[]
            {
                "AL","AK","AZ","AR","CA","CO","CT","DE","FL","GA",
                "HI","ID","IL","IN","IA","KS","KY","LA","ME","MD",
                "MA","MI","MN","MS","MO","MT","NE","NV","NH","NJ",
                "NM","NY","NC","ND","OH","OK","OR","PA","RI","SC",
                "SD","TN","TX","UT","VT","VA","WA","WV","WI","WY"
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            Member member = new Member
            {
                MemberId = _memberId,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Sex = cboGender.SelectedItem.ToString()!,
                Dob = dtpDOB.Value.Date,
                Phone = txtPhone.Text.Trim(),
                Address1 = txtAddress1.Text.Trim(),
                Address2 = txtAddress2.Text.Trim(),
                City = txtCity.Text.Trim(),
                State = cboState.SelectedItem.ToString()!,
                Zip = txtZip.Text.Trim()
            };

            bool success = _memberDal.UpdateMember(member);

            if (success)
            {
                MessageBox.Show("Member updated successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
        }
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First name is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last name is required.");
                return false;
            }

            if (cboGender.SelectedItem == null)
            {
                MessageBox.Show("Please select gender.");
                return false;
            }

            if (txtPhone.Text.Length != 10 || !txtPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be exactly 10 digits.");
                return false;
            }

            if (cboState.SelectedItem == null)
            {
                MessageBox.Show("Please select state.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtZip.Text))
            {
                MessageBox.Show("Zip code is required.");
                return false;
            }

            return true;
        }
    }
}
