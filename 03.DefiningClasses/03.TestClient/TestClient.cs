using System;
using System.Collections.Generic;

public class TestClient
{
    public static void Main()
    {
        var input = Console.ReadLine();

        var dictionary = new Dictionary<int, BankAccount>();

        while (input != "End")
        {
            var currentLine = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var command = currentLine[0];

            var id = int.Parse(currentLine[1]);

            switch (command)
            {
                case "Create":
                    Create(currentLine, dictionary, id);
                    break;
                case "Deposit":
                    Deposit(currentLine, dictionary, id);
                    break;
                case "Withdraw":
                    Withdraw(currentLine, dictionary, id);
                    break;
                case "Print":
                    Print(currentLine, dictionary, id);
                    break;
            }

            input = Console.ReadLine();
        }
    }

    public static void Print(string[] currentLine, Dictionary<int, BankAccount> dictionary, int id)
    {
        if (!ExistingAccount(id, dictionary))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            Console.WriteLine(dictionary[id]);
        }
    }

    public static void Withdraw(string[] currentLine, Dictionary<int, BankAccount> dictionary, int id)
    {
        var balance = decimal.Parse(currentLine[2]);

        if (!ExistingAccount(id, dictionary))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            if (dictionary[id].Balance >= balance)
            {
                dictionary[id].Withdraw(balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
    }

    public static void Deposit(string[] currentLine, Dictionary<int, BankAccount> dictionary, int id)
    {
        var balance = decimal.Parse(currentLine[2]);

        if (!ExistingAccount(id, dictionary))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            dictionary[id].Deposit(balance);
        }
    }

    public static void Create(string[] currentLine, Dictionary<int, BankAccount> dictionary, int id)
    {
        if (!ExistingAccount(id, dictionary))
        {
            var account = new BankAccount();

            account.Id = id;

            dictionary.Add(id, account);
        }
        else
        {
            Console.WriteLine("Account already exists");
        }
    }

    public static bool ExistingAccount(int id, Dictionary<int, BankAccount> dictionary)
    {
        return dictionary.ContainsKey(id);
    }
}

