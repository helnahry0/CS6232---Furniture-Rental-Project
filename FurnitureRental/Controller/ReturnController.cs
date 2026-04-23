using FurnitureRental.DAL;
using FurnitureRental.Model;

namespace FurnitureRental.Controller
{
    /// <summary>
    /// Controls return processing and return history operations.
    /// </summary>
    public class ReturnController
    {
        private readonly ReturnDbDal _returnDbDal;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnController"/> class.
        /// </summary>
        public ReturnController()
        {
            _returnDbDal = new ReturnDbDal();
        }

        /// <summary>
        /// Attempts to get return history for a member.
        /// </summary>
        /// <param name="memberIdInput">The entered member ID.</param>
        /// <param name="returns">The resulting return transactions.</param>
        /// <param name="errorMessage">The error message if lookup fails.</param>
        /// <returns>True if return history is found; otherwise false.</returns>
        public bool TryGetReturnHistoryForMember(
            string memberIdInput,
            out List<ReturnHistoryTransaction> returns,
            out string errorMessage)
        {
            returns = new List<ReturnHistoryTransaction>();
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

            returns = _returnDbDal.GetReturnHistoryTransactionsByMemberId(memberId);

            if (returns.Count == 0)
            {
                errorMessage = "No return history was found for that member.";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets the return items for a specific return transaction.
        /// </summary>
        /// <param name="returnId">The return transaction ID.</param>
        /// <returns>A list of items in the return transaction.</returns>
        public List<ReturnHistoryItem> GetReturnItemsForTransaction(int returnId)
        {
            return _returnDbDal.GetReturnHistoryItemsByReturnId(returnId);
        }
    }
}
