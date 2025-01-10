namespace Practice01
{
    public class BankAccount
    {
        public Guid Id { get; private set; }
        public string AccountNo { get; private set; }
        public string AccountTitle { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(string acountNo, string accountTitle)
        {
            Id = Guid.NewGuid();
            AccountNo = acountNo;
            AccountTitle = accountTitle;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new ArgumentException("No sufficient balance");

            Balance -= amount;
        }

        public void Transfer(BankAccount account, decimal amount)
        {
            if (amount > Balance)
                throw new ArgumentException("No sufficient balance");

            Withdraw(amount);
            account.Deposit(amount);
        }
    }
}
