using System;

public class BankAccountMethods
{
    public static void Main()
    {
        var acc = new BankAccount();

        acc.Id = 1;
        acc.Deposit(15);
        acc.Withdraw(10);

        Console.WriteLine(acc);
    }
}

