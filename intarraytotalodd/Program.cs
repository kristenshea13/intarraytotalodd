using System;

namespace intarraytotalodd
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //add odd numbers only from an array

            int[] numbers = { 0, 14, 12, 22, 23, 18, 11, 4, 2, 3, 8 };

            int total = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 1)
                {
                    total = total + number;
                }
            }

            Console.WriteLine($"{total}");

            Console.ReadLine();
        }
    }
}