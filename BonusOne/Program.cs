//Code Writen By Kent Butler
//Date written 1/14/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again)
            {
                String input;
                int grade, tenths, unit;

                Console.WriteLine("Welcome to the Letter Grade Converter!");
                Console.WriteLine(" ");
                Console.Write("Enter a Numerical Grade: ");
                grade = int.Parse(Console.ReadLine());
                tenths = (grade % 100) / 10;
                unit = (grade % 10);

                Console.Write("Letter Grade: ");
                if (grade < 60)
                {
                    Console.WriteLine("F");
                }
                else if (grade == 100)
                {
                    Console.WriteLine("A+");
                }
                else
                {
                    switch (tenths)
                    {
                        case 6:
                            Console.Write("D");
                            break;
                        case 7:
                            Console.Write("C");
                            break;
                        case 8:
                            Console.Write("B");
                            break;
                        case 9:
                            Console.Write("A");
                            break;
                        default:
                            Console.WriteLine("Something Went Wrong");
                            break;
                    }
                    if (unit < 4)
                    {
                        Console.WriteLine("-");
                    }
                    else if (unit < 7)
                    {
                        Console.WriteLine(" ");
                    }
                    else if (unit < 10)
                    {
                        Console.WriteLine("+");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }



                Console.Write("Continue? (y/n):");
                input = Console.ReadLine().ToLower();
                if (String.Equals("n", input))
                {
                    again = false;
                    Console.WriteLine("Goodbye.");
                }
                else if (String.Equals("y", input))
                {
                    Console.WriteLine("Starting Over.");
                }
                else
                {
                    Console.WriteLine("Invalid Entry! Ending Program.");
                    again = false;
                }
            }
        }
    }
}
