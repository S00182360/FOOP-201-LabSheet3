using System;

namespace TestCashRegister
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            CashRegister till1 = new CashRegister();
            CashRegister till2 = new CashRegister();
            till1.TillNum = 1;
            till2.TillNum = 2;


            till1.RegisterInitialise(50);
            till2.RegisterInitialise(50);

            till1.Sale(12.99M);
            till1.Sale(14M);
            till1.Sale(9.99M);
            till1.Sale(123M);

            till2.Sale(12.99M);
            till2.Sale(78M);
            till2.Sale(5.99M);
            till2.Sale(23.99M);

            till1.DisplayStatus();
            till2.DisplayStatus();




        }


    }

    public class CashRegister
    {
        private int _tillNum;
        public int TillNum
        {
            get { return _tillNum; }
            set { _tillNum = value; }
        }
        private decimal _balance = 0;
        public decimal Balance
        {
            get { return _balance; }
        }

        private int _numberOfItems = 0;
        public int NumberOfItems
        {
            get { return _numberOfItems; }
            set { _numberOfItems = value; }
        }

        public void RegisterInitialise(decimal cost)
        {
            _balance = cost;
        }

        public void Sale(decimal cost)
        {
            _balance += cost;
            _numberOfItems++;
            Console.WriteLine("Sale worth {0} added to till {1}", cost, TillNum);
        }

        public void DisplayStatus()
        {
            Console.WriteLine("Till {0} has a balance of {1} with {2} sales.", TillNum, Balance, NumberOfItems);
        }

    }
}
