﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public Person()
    {
        this.accounts = new List<BankAccount>();
    }

    public Person(string name, int age)
        : this()
    {
        this.name = name;
        this.age = age;
    }

    public Person(string name, int age, List<BankAccount> accounts)
        : this(name, age)
    {
        this.accounts.AddRange(accounts);
    }

    private string name;

    private int age;

    private List<BankAccount> accounts;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public decimal GetBalance()
    {
        return accounts.Sum(a => a.Balance);
    }
}

