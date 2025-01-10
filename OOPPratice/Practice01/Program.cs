using Practice01;

var nomanAccount = new BankAccount("9838379223", "Noman Ahmed");

nomanAccount.Deposit(50_000);

nomanAccount.Withdraw(10_000);

// nomanAccount.Withdraw(50_000);

var kabirAccount = new BankAccount("9838379234", "Kabir Sheikh");

// nomanAccount.Transfer(kabirAccount, 50_000);

nomanAccount.Transfer(kabirAccount, 20_000);

Console.WriteLine($"Noman Balance: {nomanAccount.Balance}; Kabir Balance: {kabirAccount.Balance}");



Console.ReadKey();