using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void sumcalc()
        {
            int num = 0;
            int sum = 0;

            while (sum < 100)
            {
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("The total sum is " + sum);
        }
        static void Read3even()
        {
            int count = 0, num;

            while (count < 3)
            {
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                    count++;
            }
        }
        static void readtill3digitnumber()
        {
            int num = 0;

            while (num < 100 || num > 999)
            {
                Console.Write("Enter a 3-digit number: ");
                num = int.Parse(Console.ReadLine());
            }

        }
        static void group2()
        {
            for (int k=7;k>=1;k--)
            {
                for (int j = 1; j <= k; j++)
                {
                    Console.Write(j + "");
                }
                Console.WriteLine();
            }
        }
        static void printingtriangle()
        {
            Console.Write("How many rows do you want: ");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++);
                Console.WriteLine(" ");
                for (int k = 1; k <= i; k++)
                    Console.WriteLine(i);
                Console.WriteLine();
                
            }
        }
        static void printingshape()
        {
            Console.Write("Enter the amount of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the amount of cols: ");
            int cols = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void littertask()
        {
            int days = 7;
            double litters = 0;
            bool under1 = false;
            double sum = 0;
            int daysover3 = 0;

            for (int i = 0; i < days; i++)
            {
                under1 = false;
                Console.Write("Enter the amount of litters: ");
                litters = double.Parse(Console.ReadLine());
                sum += litters;

                if (litters < 1)
                {
                    under1 = true;
                }

                if (litters < 3)
                {
                    daysover3++;
                }

                Console.WriteLine("The sum is: " + sum);
            }

        }

        static void whilepractice()
        {
            while (true)
            {
                Console.WriteLine("\nChoose one of the following options:\n1- Squared Value\n2- Line of stars\n0- Exit");
                Console.Write("Enter your choice --> ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter a number: ");
                    double input = double.Parse(Console.ReadLine());
                    Console.WriteLine(input * input);
                }
                else if (choice == 2)
                {
                    Console.Write("Enter the amount of stars you want: ");
                    int input = int.Parse(Console.ReadLine());

                    for (int i = 0; i < input; i++)
                    {
                        Console.Write("*");
                    }
                }
                else if (choice == 0)
                {
                    Console.WriteLine("See you later aligator");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number");
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            //sumcalc();
            //Read3even();
            //readtill3digitnumber();
            //group2();
            //printingtriangle();
            //littertask();
            //printingshape();
            whilepractice();
        }
    }
}
