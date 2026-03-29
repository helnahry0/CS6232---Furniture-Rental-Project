using FurnitureRental.DBAccess;
using FurnitureRental.Model;
using System.Collections.Generic;
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

        /* Search functions */

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
    }
}