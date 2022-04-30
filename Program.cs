using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        class Bank
        {
            int money = 22000;
            String ac_name = "pavan";
            String ac_num;
            static String bank_name = "HDFC";
            static public int updatedBal;
            public void depositMoney()
            {

                Console.WriteLine("Enter the amount how much you want to deposit is:");
                int depstMoney = int.Parse(Console.ReadLine());
                updatedBal = money + depstMoney;
                if (depstMoney == 0)
                {
                    Console.WriteLine(" The minimum deposit of the amount is 500 ");
                }
                else
                {
                    Console.WriteLine(" updated balance of " + ac_name + " After deposit is " + updatedBal);
                }

            }
            public void withdrawMoney()
            {
                try
                {
                    Console.WriteLine("Enter the account name is " + ac_name + " your accbal: " + updatedBal);
                    Console.WriteLine("Enter the amount how much you want to withdraw is:");
                    int withdraw = int.Parse(Console.ReadLine());
                    updatedBal = updatedBal - withdraw;
                    if (withdraw > updatedBal)
                    {
                        Console.WriteLine(" Balance does not Sufficient");
                    }
                    else
                    {
                        Console.WriteLine(" Remaining Updated balance is " + ac_name + " after withdrawal is " + updatedBal);
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine(" The enter balance in number whose in words are not taken to the inputmissmatch exception ");
                }
            }
            public void Balance()
            {
                Console.WriteLine("Display to the " + bank_name + "bank ");
                Console.WriteLine("Enter account number is ");
                ac_num = Console.ReadLine();
                Console.WriteLine("Display the account name is  " + ac_name + " your acbal: " + money);

            }
        }
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.Balance();
            b.depositMoney();
            b.withdrawMoney();
            Console.ReadLine();

        }
    }
}
