namespace BankLoan.Models
{
    public class StudentLoan : Loan
    {
        private const int interest = 1;
        private const double amount = 10000;
        public StudentLoan() : base(interest, amount)
        {
        }
    }
}
