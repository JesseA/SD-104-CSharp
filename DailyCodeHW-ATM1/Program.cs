﻿using System;

namespace DailyCodeHW_ATM1
{
    class Program
    {

        static string accName = "";

        static double initBal;

        public static double InitBal { get => initBal; set => initBal = value; }
        public static string AccName { get => accName; set => accName = value; }

        static void Main(string[] args)
        {
            while (true)
            {
                int userOption;
                //menu
                Console.WriteLine("<---- Welcome to the ATM program ---->");
                Console.WriteLine("");
                Console.WriteLine("1. Exit");
                Console.WriteLine("2. Create Checking Account");
                Console.WriteLine("3. Create Savings Account");
                Console.WriteLine("");

                //request menu option from user
                userOption= GetNumber("Please select an option: ");

                //switch based on user's option
                switch(userOption)
                {
                    case 1: Environment.Exit(0); break;
                    case 2: CreateCheckingAccount(); break;
                    case 3: CreateSavingsAccount(); break;
                    default: Console.WriteLine(); continue;

                }
            }
        }

        static int GetNumber(string optionStr)
        {
            int requestedOption = 0;

            do
            {
                Console.Write(optionStr);
            } while (!int.TryParse(Console.ReadLine(), out requestedOption));

            Console.WriteLine();

            return requestedOption;
        }

        static void CreateCheckingAccount()
        {

            //prompt user for Account Name and intial Balance
            Console.Write("Please enter the name of your new checking account: ");
            AccName = Console.ReadLine();

            do
            {
                Console.Write("Please enter the initial balance of your account: $");
            } while (!double.TryParse(Console.ReadLine(), out initBal));


            CheckingAccount myCkAcc=new CheckingAccount(InitBal);
            myCkAcc.InterestRate = .02;
            myCkAcc.AccountName = AccName;

            Console.WriteLine(myCkAcc);

            Console.WriteLine();

        }

        static void CreateSavingsAccount()
        {
            //prompt user for Account Name and intial Balance
            Console.Write("Please enter the name of your new savings account: ");
            AccName = Console.ReadLine();

            do
            {
                Console.Write("Please enter the initial balance of your account: $");
            } while (!double.TryParse(Console.ReadLine(), out initBal));


            SavingsAccount mySvAcc = new SavingsAccount(InitBal,0);
            mySvAcc.InterestRate = .03;
            mySvAcc.AccountName = AccName;

            Console.WriteLine(mySvAcc);

            Console.WriteLine();
        }
    }

    public abstract class Account
    {
        public string AccountNumber { get; set; }
        public double InterestRate { get; set; }

        public string AccountName { get; set; }

        public static double acctnum = 8881234000;
        public double Balance { get; set; }

        public Account(double initBalance)
        {
            acctnum++;
            AccountNumber = "" + acctnum;
            Balance = initBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public abstract Transaction Withdrawal(double amount);

        public override string ToString()
        {
            string returnStr= "Account Number: "+AccountNumber+"  Balance: $"+Balance+"  Interest Rate: "+InterestRate+"%";
            if(AccountName!="")
            {
                returnStr = "Account Name: " + AccountName+"  "+ returnStr ;
            }
            return returnStr;
        }
    }

    public class CheckingAccount : Account
    {

        public CheckingAccount(double initBalance) : base(initBalance)
        {

        }

        public override Transaction Withdrawal(double amount)
        {
            Transaction myTransaction = new Transaction(AccountNumber, amount, DateTime.Now);

            if (amount > Balance)
            {
                string message = "Transaction failed: Insufficient funds.";
                myTransaction.Detail = message;
                Console.WriteLine(message);
            }
            else
            {
                Balance -= amount;
                myTransaction.Successful = true;
                string message = String.Format("Account#: {0} was debited: ${1}", myTransaction.AccountNumber, myTransaction.Amount);
                myTransaction.Detail = message;
                Console.WriteLine("Withdraw successful. " + message);
            }


            return myTransaction;
        }


    }

    public class Transaction
    {
        public Transaction(string accountNumber, double amount, DateTime timestamp)
        {
            AccountNumber = accountNumber;
            Amount = amount;
            Successful = false;
            TimeStamp = timestamp;
        }
        public string AccountNumber { get; set; }
        public double Amount { get; set; }

        public bool Successful { get; set; }

        public DateTime TimeStamp { get; set; }
        public string Detail { get; set; }

    }

    class SavingsAccount : Account
    {
        public int WithdrawalsThisMonth { get; set; }

        private const int MONTHLY_WITHDRAWAL_LIMIT = 5;

        public void ProcessProfit()
        {
            Balance *= (1 + (InterestRate / 100));
        }

        public SavingsAccount(double initBalance, int withdrawlsthismonth) : base(initBalance)
        {
            WithdrawalsThisMonth = withdrawlsthismonth;
            if (initBalance > 10000)
            {
                InterestRate = 8;
            }
            else if (initBalance > 5000)
            {
                InterestRate = 4;
            }
            else if (initBalance > 5)
            {
                InterestRate = 2;
            }
            else
            {
                InterestRate = -10;
            }
        }


        public override Transaction Withdrawal(double amount)
        {
            Transaction myTransaction = new Transaction(AccountNumber, amount, DateTime.Now);

            if (amount > Balance)
            {
                string message = "Transaction failed: Insufficient funds.";
                myTransaction.Detail = message;
                Console.WriteLine(message);
            }
            else if (WithdrawalsThisMonth >= MONTHLY_WITHDRAWAL_LIMIT)
            {
                string message = "Transaction failed: Monthly Withdrawal Limit Reached.";
                myTransaction.Detail = message;
                Console.WriteLine(message);
            }
            else
            {
                Balance -= amount;
                myTransaction.Successful = true;
                WithdrawalsThisMonth++;
                string message = String.Format("Account#: {0} was debited: ${1}", myTransaction.AccountNumber, myTransaction.Amount);
                myTransaction.Detail = message;
                Console.WriteLine("Withdraw successful. " + message);
            }


            return myTransaction;
        }
    }

}
