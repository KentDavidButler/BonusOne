//Code Writen By Kent Butler
//Date written 1/14/2019
//Last Edited 3/25/2019

using System;

namespace BonusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again)
            {
                string input;
                bool validNum;
                int num;

                Console.WriteLine("Welcome to the Letter Grade Converter!");
                Console.WriteLine(" ");

                do
                {
                    Console.Write("Enter a Numerical Grade: ");

                    input = Console.ReadLine();
                    num = Validation.IsNum(input);
                    validNum = Validation.IsBetweenZeroAndHund(num);
                } while (!validNum);

                Grade grade = new Grade(num);
                Console.WriteLine("Letter Grade: " + grade.GetGradeLetter());

                again = Validation.Continue();

            }
        }
    }
}
