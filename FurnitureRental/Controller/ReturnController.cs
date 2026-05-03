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

        /// <summary>
        /// Attempts to get all returnable rental items for a member.
        /// </summary>
        /// <param name="memberIdInput">The member ID input.</param>
        /// <param name="items">The returnable items for the member.</param>
        /// <param name="errorMessage">The error message if the lookup fails.</param>
        /// <returns><c>true</c> if returnable items are found; otherwise <c>false</c>.</returns>
        public bool TryGetReturnableItemsForMember(
            string memberIdInput,
            out List<ReturnableRentalItem> items,
            out string errorMessage)
        {
            items = new List<ReturnableRentalItem>();
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(memberIdInput))
            {
                errorMessage = "Member ID is required.";
                return false;
            }

            if (!int.TryParse(memberIdInput.Trim(), out int memberId))
            {
                errorMessage = "Member ID must be a valid number.";
                return false;
            }

            items = _returnDbDal.GetReturnableItemsByMemberId(memberId);

            if (items.Count == 0)
            {
                errorMessage = "No returnable rental items were found for that member.";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Attempts to submit a return transaction.
        /// </summary>
        /// <param name="returnTransaction">The return transaction to submit.</param>
        /// <param name="savedReturnTransaction">The saved return transaction if successful.</param>
        /// <param name="errorMessage">The error message if submission fails.</param>
        /// <returns><c>true</c> if the return transaction is submitted successfully; otherwise <c>false</c>.</returns>
        public bool TrySubmitReturn(
            ReturnTransaction returnTransaction,
            out ReturnTransaction? savedReturnTransaction,
            out string errorMessage)
        {
            savedReturnTransaction = null;
            errorMessage = string.Empty;

            if (returnTransaction == null)
            {
                errorMessage = "Return transaction is required.";
                return false;
            }

            if (returnTransaction.MemberId <= 0)
            {
                errorMessage = "A valid member is required.";
                return false;
            }

            if (returnTransaction.EmployeeId <= 0)
            {
                errorMessage = "A valid employee is required.";
                return false;
            }

            if (returnTransaction.Items == null || returnTransaction.Items.Count == 0)
            {
                errorMessage = "At least one item must be selected for return.";
                return false;
            }

            foreach (ReturnItem item in returnTransaction.Items)
            {
                if (item.RentalId <= 0)
                {
                    errorMessage = "Each return item must have a valid rental transaction ID.";
                    return false;
                }

                if (item.FurnitureId <= 0)
                {
                    errorMessage = "Each return item must have a valid furniture ID.";
                    return false;
                }

                if (item.QuantityToReturn <= 0)
                {
                    errorMessage = $"Return quantity must be greater than zero for furniture ID {item.FurnitureId}.";
                    return false;
                }

                if (item.QuantityToReturn > item.QuantityRemaining)
                {
                    errorMessage =
                        $"Cannot return more than the remaining quantity for furniture ID {item.FurnitureId}. Remaining: {item.QuantityRemaining}.";
                    return false;
                }

                item.ReturnDate = returnTransaction.ReturnDate;
                item.FineOrRefundAmount = CalculateFineOrRefund(item);
            }

            try
            {
                savedReturnTransaction = _returnDbDal.SubmitReturnTransaction(returnTransaction);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Calculates the fine or refund amount for a return item.
        /// Positive values indicate fines. Negative values indicate refunds.
        /// Same-day returns are charged as one rental day.
        /// </summary>
        /// <param name="item">The return item.</param>
        /// <returns>The fine or refund amount.</returns>
        private static decimal CalculateFineOrRefund(ReturnItem item)
        {
            int plannedDays = Math.Max(1, (item.DueDate.Date - item.RentalDate.Date).Days + 1);
            int actualDays = Math.Max(1, (item.ReturnDate.Date - item.RentalDate.Date).Days + 1);

            int differenceInDays = actualDays - plannedDays;

            return differenceInDays * item.DailyRentalRate * item.QuantityToReturn;
        }

    }
}
