using FurnitureRental.DAL;
using FurnitureRental.Model;
using System.Collections.Generic;

namespace FurnitureRental.Controller
{
    /// <summary>
    /// Controls rental history operations.
    /// </summary>
    public class RentalController
    {
        private readonly RentalDbDal _rentalDbDal;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalController"/> class.
        /// </summary>
        public RentalController()
        {
            _rentalDbDal = new RentalDbDal();
        }

        /// <summary>
        /// Attempts to get rental history for a member.
        /// </summary>
        /// <param name="memberIdInput">The entered member ID.</param>
        /// <param name="rentals">The resulting rental transactions.</param>
        /// <param name="errorMessage">The error message if the lookup fails.</param>
        /// <returns><c>true</c> if rental history is found; otherwise <c>false</c>.</returns>
        public bool TryGetRentalHistoryForMember(string memberIdInput, out List<RentalTransaction> rentals, out string errorMessage)
        {
            rentals = new List<RentalTransaction>();
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

            rentals = _rentalDbDal.GetRentalTransactionsByMemberId(memberId);

            if (rentals.Count == 0)
            {
                errorMessage = "No rental history was found for that member.";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets the rental history items for a rental transaction.
        /// </summary>
        /// <param name="rentalId">The rental transaction ID.</param>
        /// <returns>A list of items in the rental transaction.</returns>
        public List<RentalHistoryItem> GetRentalItemsForTransaction(int rentalId)
        {
            return _rentalDbDal.GetRentalItemsByRentalId(rentalId);
        }

    }
}