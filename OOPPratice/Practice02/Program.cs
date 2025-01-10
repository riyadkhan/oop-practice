using Practice02;

var creditCard = new CreditCard("8976-3738-3829-0986", "Rajib Chowdhury");

Console.WriteLine($"Credit remaining: {creditCard.RemainingCredit}");


creditCard.PayBill(50_000);

creditCard.CashWithdraw(20_000);
creditCard.CashWithdraw(20_000);
creditCard.CashWithdraw(20_000);
creditCard.CashWithdraw(20_000);
creditCard.CashWithdraw(20_000);
creditCard.CashWithdraw(20_000);

Console.WriteLine($"Credit remaining: {creditCard.RemainingCredit}");

Console.ReadKey();