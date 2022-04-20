using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  name");
            string name = Console.ReadLine();
            Console.WriteLine("Hi! " + name + "welcome to the  world of c#");
            Console.Read();


            int num;
            Console.WriteLine(" Enter number");
            num = Convert.ToInt32(Console.ReadLine());


            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("odd");
            }

            Console.Read();

            Console.WriteLine("Enter tthe num1");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter tthe num2");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter tthe num3");
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("the largest" + n1);
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("the largest" + n2);
            }
            else
            {
                Console.WriteLine("the largest" + n3);
            }
            Console.Read();





            {
                Console.WriteLine("Enter first number");
                int N1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int N2 = Convert.ToInt32(Console.ReadLine());
                if (N1 == N2)
                {
                    Console.WriteLine(N1 + " and " + N2 + "are equal");
                }
                else if (N1 != N2)
                {
                    Console.WriteLine(N1 + " and " + N2 + "are not equal");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
                Console.ReadLine();
            }

            {
                Console.WriteLine("Enter number");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    Console.WriteLine(n + " is positive number");
                }
                else if (n < 0)
                {
                    Console.WriteLine(n + " is negative number");
                }
                Console.ReadLine();

                int number1, number2, result;
                char operation;
                Console.Write("Enter the first number :");
                number1 = Convert.ToInt32(Console.ReadLine());



                Console.Write("Enter the second number :");
                number2 = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("Choose the operation");
                Console.WriteLine("1:- +");
                Console.WriteLine("2:- - ");
                Console.WriteLine("3:- * ");
                Console.WriteLine("4:- % ");
                operation = Convert.ToChar(Console.ReadLine());
                switch (operation)
                {
                    case '1':
                        result = number1 + number2;
                        Console.WriteLine("The addition of two number is : {0}", result);
                        break;
                    case '2':
                        result = number1 - number2;
                        Console.WriteLine("The subtraction of two number is : {0}", result);
                        break;
                    case '3':
                        result = number1 * number2;
                        Console.WriteLine("The multiplication of two number is : {0}", result);
                        break;
                    case '4':
                        result = number1 / number2;
                        Console.WriteLine("The division of two number is : {0}", result);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;




                }
                Console.ReadLine();
            }
    }
}
