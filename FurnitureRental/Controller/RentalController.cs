using FurnitureRental.DAL;
using FurnitureRental.Model;

namespace FurnitureRental.Controller
{
    /// <summary>
    /// Controls rental submission and rental history operations.
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
        /// Attempts to submit a rental transaction.
        /// </summary>
        /// <param name="rentalTransaction">The rental transaction to submit.</param>
        /// <param name="savedTransaction">The saved transaction if successful.</param>
        /// <param name="errorMessage">The validation or save error message.</param>
        /// <returns>True if the transaction is submitted successfully; otherwise false.</returns>
        public bool TrySubmitRentalTransaction(
            RentalTransaction rentalTransaction,
            out RentalTransaction? savedTransaction,
            out string errorMessage)
        {
            savedTransaction = null;
            errorMessage = ValidateRentalTransaction(rentalTransaction);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                return false;
            }

            try
            {
                savedTransaction = _rentalDbDal.SubmitRentalTransaction(rentalTransaction);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Attempts to get rental history for a member.
        /// </summary>
        /// <param name="memberIdInput">The member ID entered by the user.</param>
        /// <param name="rentals">The list of rental transactions found.</param>
        /// <param name="errorMessage">The error message if no results or invalid input.</param>
        /// <returns>True if rental history is found; otherwise false.</returns>
        public bool TryGetRentalHistoryForMember(string memberIdInput, out List<RentalHistoryTransaction> rentals, out string errorMessage)
        {
            rentals = new List<RentalHistoryTransaction>();
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

            rentals = _rentalDbDal.GetRentalHistoryTransactionsByMemberId(memberId);

            if (rentals.Count == 0)
            {
                errorMessage = "No rental history was found for that member.";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets the rental items for a specific rental transaction.
        /// </summary>
        /// <param name="rentalId">The rental transaction ID.</param>
        /// <returns>A list of items in the rental transaction.</returns>
        public List<RentalHistoryItem> GetRentalItemsForTransaction(int rentalId)
        {
            return _rentalDbDal.GetRentalItemsByRentalId(rentalId);
        }

        /// <summary>
        /// Validates a rental transaction before submission.
        /// </summary>
        /// <param name="rentalTransaction">The rental transaction to validate.</param>
        /// <returns>An error message if invalid; otherwise an empty string.</returns>
        private static string ValidateRentalTransaction(RentalTransaction rentalTransaction)
        {
            if (rentalTransaction == null)
            {
                return "Rental transaction cannot be null.";
            }

            if (rentalTransaction.MemberId <= 0)
            {
                return "A valid member ID is required.";
            }

            if (rentalTransaction.EmployeeId <= 0)
            {
                return "A valid employee ID is required.";
            }

            if (rentalTransaction.Items == null || rentalTransaction.Items.Count == 0)
            {
                return "At least one rental item is required.";
            }

            if (rentalTransaction.Items.Any(x => x.FurnitureId <= 0))
            {
                return "Each item must have a valid furniture ID.";
            }

            if (rentalTransaction.Items.Any(x => x.QuantityRented <= 0))
            {
                return "Each item must have a quantity greater than zero.";
            }

            bool hasDuplicateFurnitureIds = rentalTransaction.Items
                .GroupBy(x => x.FurnitureId)
                .Any(g => g.Count() > 1);

            if (hasDuplicateFurnitureIds)
            {
                return "A furniture item can only appear once in the transaction. Update the quantity instead.";
            }

            if (rentalTransaction.DueDate.Date < rentalTransaction.RentalDate.Date)
            {
                return "Due date cannot be before the rental date.";
            }

            return string.Empty;
        }
    }
}