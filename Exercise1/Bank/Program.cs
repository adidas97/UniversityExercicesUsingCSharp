﻿using System;
using System.Collections.Generic;
namespace Bank
{
    class Program
    {
        public static void PrintList(List<BankAccount> bankAccounts)
        {
            foreach (BankAccount account in bankAccounts)
                Console.WriteLine(account);
        }
        static void Main(string[] args)
        {
            
            List<BankAccount> bankAccounts = new List<BankAccount>();
            BankAccount universityChecking, mariaSavings, peterTimeDepositing;
            universityChecking = new CheckingAccount("TU", 100000);
            mariaSavings = new SavingAccount("Maria", 5);
            peterTimeDepositing = new TimeDepositAccount("Peter", 5, 6);
            bankAccounts.Add(universityChecking);
            bankAccounts.Add(mariaSavings);
            bankAccounts.Add(peterTimeDepositing);
            bankAccounts[0].Transfer(bankAccounts[1], 500);
            bankAccounts[0].Transfer(bankAccounts[2], 500);
            Console.WriteLine(" Balances");
            PrintList(bankAccounts);
            Console.WriteLine("\nThe deposits of Peter and Maria are {0}.",
            (bankAccounts[2] == bankAccounts[1]) ? "equal" : "not equal");
            bankAccounts[0].Withdraw(500);
            bankAccounts[1].Withdraw(50);
            bankAccounts[2].Withdraw(50);
            Console.WriteLine("\n Balances after withdraw");
            PrintList(bankAccounts);
            Console.WriteLine("\nThe deposits of Peter and Maria are {0}.",
            (bankAccounts[2] == bankAccounts[1]) ? "equal" : "not equal");
            bankAccounts[0].Deposit(1000);
            bankAccounts[1].Deposit(200);
            bankAccounts[2].Deposit(200);
            Console.WriteLine("\n Balances after deposit");
            PrintList(bankAccounts);
            foreach (BankAccount account in bankAccounts)
                account.EndOfMonth();
            Console.WriteLine("\n Balances at the end of month");
            PrintList(bankAccounts);
            double sum = 0.0;
            foreach (BankAccount account in bankAccounts)
                sum += account.Balance;
            Console.WriteLine("Sum of deposits: {0, 20:F2} BGN", sum);
        }
    }
}
