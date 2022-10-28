using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    class bank
    {
        private double balance = 100000;


        public double bal
        {
            get { return balance; }
            set { balance = value; }
        }
    }
    class fuctions
    {
        bank i = new bank();
        string name;
        int account;
        double withdraw, dep, tobal;

        public void fun1()
        {
            Console.WriteLine("Enter Name of the depositor :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Deposit Amount :");
            dep = Convert.ToDouble(Console.ReadLine());
            tobal = i.bal + dep;

            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Name of the depositor : " + name);
            Console.WriteLine("Account Number: " + account);
            Console.WriteLine("Total Balance amount in the account  : " + tobal);

        }
        public void fun2()
        {
            Console.WriteLine("Enter Account Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Withdraw Amount :");
            withdraw = Convert.ToDouble(Console.ReadLine());
            if (withdraw <= i.bal)
            {
                tobal = i.bal - withdraw;
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("Account Name : " + name);
                Console.WriteLine("Account Number: " + account);
                Console.WriteLine("After Withdraw Amount balnace is : " + tobal);
            }
            else
                Console.WriteLine("\n\nWithdraw Ammount does not Exist your Account.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            char agn;
            do
            {
                fuctions k = new fuctions();
                int num;
                Console.WriteLine("Please Select Any Function.");
                Console.WriteLine("\nPress 1 for Deposit an Amount. \nPress 2 for Withdraw an Amount.");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        k.fun1();
                        break;
                    case 2:
                        k.fun2();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection!!!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue this program? (y/n)");
                agn = Convert.ToChar(Console.ReadLine());

            } while (agn == 'y');

            Console.ReadKey();
        }
    }
}