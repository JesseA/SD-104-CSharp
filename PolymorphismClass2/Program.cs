using System;

namespace PolymorphismClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount myChkAcct = new CheckingAccount(1000);
            SavingsAccount mySavAcct = new SavingsAccount(100000,4);
            Console.WriteLine("Initiate withdrawl of $350 from Acct #" + myChkAcct.AccountNumber);
            myChkAcct.Withdrawal(350);
            Console.WriteLine("Balance: $" + myChkAcct.Balance);
            Console.WriteLine();

            Console.WriteLine("Initiate withdrawl of $2000 from Acct #" + mySavAcct.AccountNumber);
            mySavAcct.Withdrawal(2000);
            Console.WriteLine("Balance: $" + mySavAcct.Balance);
            Console.WriteLine();

            Console.WriteLine("Initiate withdrawl of $2000 from Acct #" + myChkAcct.AccountNumber);
            myChkAcct.Withdrawal(2000);
            Console.WriteLine("Balance: $" + myChkAcct.Balance);
            Console.WriteLine();

            Console.WriteLine("Initiate withdrawl of $2000 from Acct #" + mySavAcct.AccountNumber);
            mySavAcct.Withdrawal(2000);
            Console.WriteLine("Balance: $" + mySavAcct.Balance);
            Console.WriteLine();

            Console.WriteLine("Processing divedend with interest rate "+ mySavAcct.InterestRate +"% for Acct #" + mySavAcct.AccountNumber);
            mySavAcct.ProcessProfit();
            Console.WriteLine("Balance: $" + mySavAcct.Balance);
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    public abstract class Account
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

        public abstract Transaction Withdrawal(double amount);
    }

    public class CheckingAccount : Account
    {
        public CheckingAccount(double initBalance) : base(initBalance)
        {
            
        }

        public override Transaction Withdrawal(double amount)
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

    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public int WithdrawalsThisMonth { get; set; }

        private const int MONTHLY_WITHDRAWAL_LIMIT = 5;

        public void ProcessProfit()
        {
            Balance *= (1+(InterestRate / 100));
        }

        public SavingsAccount(double initBalance, int withdrawlsthismonth):base(initBalance)
        {
            WithdrawalsThisMonth = withdrawlsthismonth;
            if(initBalance>10000)
            {
                InterestRate = 8;
            }
            else if(initBalance>5000)
            {
                InterestRate = 4;
            }
            else if(initBalance>5)
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
            else if(WithdrawalsThisMonth>=MONTHLY_WITHDRAWAL_LIMIT)
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
