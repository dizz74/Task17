using System;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("БАНК");
            Account<long> account1 = new Account<long>();
            account1.SetOwner("Иванов ИИ");
            account1.SetNumber(429043432423);
            account1.SetBalance(500.53);
            account1.PrintInfo();

            Account<string> account2 = new Account<string>();
            account2.SetOwner("Петров ИИ");
            account2.SetNumber("SWIFT56789034324");
            account2.SetBalance(504340.53);
            account2.PrintInfo();

            Console.ReadKey();
        }
    }


    class Account<T>
    {

        T number;
        string owner;
        double balance;

        public void SetOwner(string fio)
        {
            owner = fio;
        }


        public string GetOwner()
        {
            return owner;
        }

        public void SetNumber(T num)
        {
            number = num;
        }


        public T GetNumber()
        {
            return number;
        }
        public void SetBalance(double val)
        {
            balance = val;
        }


        public double GetBalance()
        {
            return balance;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Счет #{0} на имя {1}, баланс {2}", number, owner, balance);
        }
    }
}
