namespace BankAccountAppAnotherWay
{
    public class Account
    {
        public Account(string accountNo, string customerName)
        {
            AccountNo = accountNo;
            CustomerName = customerName;
        }

        public string CustomerName { get; set; }

        public string AccountNo { get; set; }

        public string Deposit(double amount)
        {
            Balance += amount;
        }

        protected double Balance { get; private set; }
    }
}