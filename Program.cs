using System;

namespace LabSheet3
{
    class MainClass
    {
        /*3.    Create a class called Bank Account with the following properties – 
        * Account Number,                                      DONE
        * Account Holder,                                      
        * Balance.                                             
        * Create two bank account objects                      
        * and display the bank details in your program.        
        */

        public static void Main(string[] args)
        {
            double depositAmount, withdrawalAmount;
            BankAccount ba1 = new BankAccount(101, "Sam", 35.99);
            //ba1.AccountName = "Sam";
            //ba1.AccountNumber = 101;
            //ba1.Balance = 35.99;


            Console.WriteLine("ba1 info: ");
            Console.WriteLine(ba1.AccountName);
            Console.WriteLine(ba1.AccountNumber);
            Console.WriteLine(ba1.Balance);
            Console.WriteLine("");
            Console.WriteLine("");



            BankAccount ba2 = new BankAccount(102, "John", 1099.87);
            //ba2.AccountName = "John";
            //ba2.AccountNumber = 102;
            //ba2.Balance = 1099.87;

            Console.WriteLine("ba2 info:  ");
            Console.WriteLine(ba2.AccountName);
            Console.WriteLine(ba2.AccountNumber);
            Console.WriteLine(ba2.Balance);
            Console.WriteLine("");
            Console.WriteLine("");

            depositAmount = 15;
            withdrawalAmount = 75.01;

            ba1.Deposit(depositAmount);

            Console.WriteLine("balance from Main[]:  " + ba1.Balance);

            ba1.Withdraw(withdrawalAmount);
            ba2.Withdraw(withdrawalAmount);

            Console.WriteLine("ba1 balance after withdrawl:  " + ba1.Balance);
            Console.WriteLine("ba2 balance after withdrawl:  " + ba2.Balance);
        }
    }

    public class BankAccount
    {


        public BankAccount(int AccountNumber, string AccountName, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountName = AccountName;
            this.Balance = Balance;
        }

        private int _accountNumber;
        private string _accountName;
        private double _balance;
        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public string AccountName
        {
            get { return _accountName; }
            set { _accountName = value; }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("Your new balance is:  " + Balance);

        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
                Balance -= amount;
            else
                Console.WriteLine("Insufficient Funds.");

        }
    }
}
