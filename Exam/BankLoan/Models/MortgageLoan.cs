namespace BankLoan.Models
{
    internal class MortgageLoan : Loan
    {
        private const int interest = 3;
        private const double amount = 50_000;
        public MortgageLoan() : base(interest, amount)
        {
        }
    }
}
