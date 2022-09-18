using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salary();

        }


        private static void Salary()
        {
            try
            {
                Console.WriteLine("What is your annual income ?");
                int income = Convert.ToInt32(Console.ReadLine());

                double monthly = 12;
                double daily = 365;
                double hourly = 8765;
                double minute = 525948;
                double second = 31556926;

                if (income >= 200000)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Monthly income: {Math.Round((income / monthly), 2)}");
                    Console.WriteLine($"Daily income: {Math.Round((income / daily), 2)}");
                    Console.WriteLine($"Hourly income: {Math.Round((income / hourly), 2)}");
                    Console.WriteLine($"Minute income: {Math.Round((income / minute), 2)}");
                    Console.WriteLine($"Per second income: {Math.Round((income / second), 2)}");

                    double result = Math.Round((income / second), 2);
                    while (result >= 0)
                    {
                        Console.WriteLine("You earned" + " " + result + " " + "since your input");
                        System.Threading.Thread.Sleep(1000);
                        double calc = Math.Round((income / second), 2);
                        result += calc;
                    }
                    Console.ReadKey();

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine($"Monthly income: {income / monthly}");
                    Console.WriteLine($"Daily income: {income / daily}");
                    Console.WriteLine($"Hourly income: {income / hourly}");
                    Console.WriteLine($"Minute income: {income / minute}");
                    Console.WriteLine($"Per second income: {income / second}");

                    double result = income / second;
                    while (result >= 0)
                    {
                        Console.WriteLine("You earned" + " " + result + " " + "since your input");
                        System.Threading.Thread.Sleep(1000);
                        double calc = Math.Round((income / second), 2);
                        result += calc;
                    }
                    Console.ReadKey();

                }

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter only numbers!");
            }
            


            

        }
    }
}

