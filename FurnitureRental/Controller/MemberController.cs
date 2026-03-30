using FurnitureRental.DBAccess;
using FurnitureRental.Model;
using System.Text.RegularExpressions;

namespace FurnitureRental.Controller
{
    public class MemberController
    {
        private readonly MemberDbDal _memberDbDal;

        public MemberController()
        {
            _memberDbDal = new MemberDbDal();
        }

        /* Tries to add a member */
        public bool TryAddMember(Member member, out string errorMessage)
        {
            errorMessage = ValidateMember(member);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                return false;
            }

            _memberDbDal.AddMember(member);
            return true;
        }

        /* Tries to update a current member */
        public bool TryUpdateMember(Member member, out string errorMessage)
        {
            errorMessage = ValidateMember(member);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                return false;
            }

            bool updated = _memberDbDal.UpdateMember(member);

            if (!updated)
            {
                errorMessage = "No member was found to update.";
                return false;
            }

            return true;
        }

        /*Tries to search for a member by their id */
        public bool TrySearchByMemberId(string memberIdInput, out Member? member, out string errorMessage)
        {
            member = null;
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(memberIdInput))
            {
                errorMessage = "Member ID is required.";
                return false;
            }

            if (!int.TryParse(memberIdInput, out int memberId))
            {
                errorMessage = "Member ID must be a valid number.";
                return false;
            }

            member = _memberDbDal.GetMemberById(memberId);

            if (member == null)
            {
                errorMessage = "No member was found with that ID.";
                return false;
            }

            return true;
        }

        /* Tries to search for a member by their phone number */
        public bool TrySearchByPhone(string phoneInput, out Member? member, out string errorMessage)
        {
            member = null;
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(phoneInput))
            {
                errorMessage = "Phone number is required.";
                return false;
            }

            if (!Regex.IsMatch(phoneInput, @"^\d{10}$"))
            {
                errorMessage = "Phone number must be exactly 10 digits.";
                return false;
            }

            member = _memberDbDal.GetMemberByPhone(phoneInput);

            if (member == null)
            {
                errorMessage = "No member was found with that phone number.";
                return false;
            }

            return true;
        }

        /* Tries to search for a member by their full name */
        public bool TrySearchByFullName(string firstName, string lastName, out List<Member> members, out string errorMessage)
        {
            members = new List<Member>();
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                errorMessage = "Both first name and last name are required.";
                return false;
            }

            members = _memberDbDal.GetMembersByFullName(firstName.Trim(), lastName.Trim());

            if (members.Count == 0)
            {
                errorMessage = "No members were found with that full name.";
                return false;
            }

            return true;
        }

        /* Checks if a member is valid */
        private static string ValidateMember(Member member)
        {
            if (string.IsNullOrWhiteSpace(member.FirstName))
            {
                return "First name is required.";
            }

            if (string.IsNullOrWhiteSpace(member.LastName))
            {
                return "Last name is required.";
            }

            if (string.IsNullOrWhiteSpace(member.Sex))
            {
                return "Sex is required.";
            }

            if (string.IsNullOrWhiteSpace(member.Phone))
            {
                return "Phone number is required.";
            }

            if (!Regex.IsMatch(member.Phone, @"^\d{10}$"))
            {
                return "Phone number must be exactly 10 digits.";
            }

            if (string.IsNullOrWhiteSpace(member.Address1))
            {
                return "Address line 1 is required.";
            }

            if (string.IsNullOrWhiteSpace(member.City))
            {
                return "City is required.";
            }

            if (string.IsNullOrWhiteSpace(member.State) || member.State.Length != 2)
            {
                return "State must be a 2-letter abbreviation.";
            }

            if (string.IsNullOrWhiteSpace(member.Zip))
            {
                return "ZIP code is required.";
            }

            return string.Empty;
        }
    }
}