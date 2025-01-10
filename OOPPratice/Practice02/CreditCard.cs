namespace Practice02
{
    public class CreditCard
    {
        private const decimal MAX_CREDIT_LIMIT = 500_000;
        private const decimal DAILY_WITHDRAW_LIMIT = 100_000;
        private const decimal TRANSACTION_LIMIT = 20_000;

        public string CardNumber { get; private set; }
        public string CardHolder { get; private set; }
        public decimal RemainingCredit { get; private set; }

        private DateTime LastWithdrawDate { get; set; }
        private decimal DailyTotalWithdraw { get; set; }


        public CreditCard(string cardNumber, string cardHolder)
        {
            CardNumber = cardNumber;
            CardHolder = cardHolder;
            RemainingCredit = MAX_CREDIT_LIMIT;
            LastWithdrawDate = DateTime.Now.Date;
        }

        public void CashWithdraw(decimal amount)
        {
            if (LastWithdrawDate != DateTime.Now.Date)
            {
                LastWithdrawDate = DateTime.Now.Date;
                DailyTotalWithdraw = 0;
            }

            if (amount > TRANSACTION_LIMIT)
                throw new ArgumentException($"Each transaction limit is {TRANSACTION_LIMIT}");

            if ((DailyTotalWithdraw + amount) > DAILY_WITHDRAW_LIMIT)
                throw new ArgumentException("Your Daily withdrawal limit has been over");

            if (amount > RemainingCredit)
                throw new ArgumentException($"No Sufficient Credit");

            DailyTotalWithdraw += amount;
            RemainingCredit -= amount;
        }

        public void PayBill(decimal amount)
        {
            if (amount > RemainingCredit)
                throw new ArgumentException("No Sufficient Credit");

            RemainingCredit -= amount;
        }
    }
}
