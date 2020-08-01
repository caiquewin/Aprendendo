

namespace Exemplo_de_herança.Entities
{
    class BussinesAccount : Account
    {
        public double LoanLiumit { get; set; }

        public BussinesAccount()
        {

        }

        public BussinesAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLiumit = loanLimit;
        }
        public void Loan(double amount)
        {
            if (amount <= LoanLiumit)
            {
                Balance += amount;
            }
        }
        // alterações
    }
}
