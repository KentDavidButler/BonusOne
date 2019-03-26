
using System;

namespace BonusOne
{
    public class Validation
    {

        public static int IsNum(string input)
        {
            if (int.TryParse(input, out int num))
            {
                return num;
            }
            else
            {
                return -1;
            }
        }

        public static bool IsBetweenZeroAndHund(int num)
        {
            if(num >=0 && num <= 100)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Not a Valid Number");
                return false;
            }
        }

        public static bool Continue()
        {
            do
            {
                Console.Write("Continue? (y/n):");
                string input = Console.ReadLine().ToLower();

                if (String.Equals("n", input))
                {
                    Console.WriteLine("Goodbye.");
                    return false;
                }
                else if (String.Equals("y", input))
                {
                    Console.WriteLine("Starting Over.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid Entry!");
                }

            } while (true);

        }
    }
}
