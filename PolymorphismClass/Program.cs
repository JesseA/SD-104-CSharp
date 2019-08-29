using System;

namespace PolymorphismClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount myChkAcct = new CheckingAccount(1000);
            CheckingAccount myChkAcct2 = new CheckingAccount(100000);
            Console.WriteLine("Initiate withdrawl of $350 from Acct# "+myChkAcct.AccountNumber);
            myChkAcct.Withdrawl(350);
            Console.WriteLine("Balance: $" + myChkAcct.Balance);
            Console.WriteLine();

            Console.WriteLine("Initiate withdrawl of $2000 from Acct# " + myChkAcct2.AccountNumber);
            myChkAcct2.Withdrawl(2000);
            Console.WriteLine("Balance: $" + myChkAcct2.Balance);
            Console.WriteLine();

            Console.WriteLine("Initiate withdrawl of $2000 from Acct# " + myChkAcct.AccountNumber);
            myChkAcct.Withdrawl(2000);
            Console.WriteLine("Balance: $" + myChkAcct.Balance);
            Console.WriteLine();


            Console.ReadLine();
        }
    }

    public class Account
    {
        public string AccountNumber { get; set; }

        public static double acctnum = 8881234000;
        public double Balance { get; set; }

        public Account(double initBalance)
        {
            acctnum++;
            AccountNumber=""+acctnum;
            Balance = initBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }

    public class CheckingAccount : Account
    {
        public CheckingAccount(double initBalance) : base(initBalance)
        {
            
        }

        public Transaction Withdrawl(double amount)
        {
            Transaction myTransaction = new Transaction(AccountNumber, amount,DateTime.Now);

            if(amount>Balance)
            {
                string message = "Transaction failed: Insufficient funds.";
                myTransaction.Detail = message;
                Console.WriteLine(message);
            }
            else
            {
                Balance -= amount;
                myTransaction.Successful = true;
                string message = String.Format("Account#: {0} was debited: ${1}",myTransaction.AccountNumber,myTransaction.Amount);
                myTransaction.Detail = message;
                Console.WriteLine("Withdraw successful. "+message);
            }


            return myTransaction;
        }

        
    }

    public class Transaction
    {
        public Transaction(string accountNumber,double amount,DateTime timestamp)
        {
            AccountNumber = accountNumber;
            Amount = amount;
            Successful = false;
            TimeStamp = timestamp;
        }
        public string AccountNumber { get; set;}
        public double Amount { get; set; }

        public bool Successful { get; set; }

        public DateTime TimeStamp { get; set; }
        public string Detail { get; set; }

    }
}
