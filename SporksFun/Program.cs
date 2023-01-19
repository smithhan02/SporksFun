// Hannah Smith Mission #2 assignment 
using System;

namespace SporksFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] rollTotals = new int[11];
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many times would you like to simulate?");
            int rolls = Convert.ToInt32(Console.ReadLine());

            // simulate roll of the die 
            for (int i = 0; i < rolls; i++)
            {
                int Dice1 = r.Next(1,7);

                int Dice2 = r.Next(1,7);

                int roll = Dice1 + Dice2;

                rollTotals[roll - 2]++;
            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \" * \" represents 1% of the total number of rolls.");
            Console.WriteLine(" Total number of rolls " + rolls);

            //print out results from the array
            for (int i = 0; i < 11; i++)
            {
                int percentage = (int)((rollTotals[i] / (float)rolls) * 100);
                string histogram = "";

                // print histogram with *'s
                for (int count = 0; count < percentage; count++)
                {
                    histogram = histogram + "*";
                }
                Console.WriteLine((i + 1) + ": " + histogram);
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye! ");



        }
    }
}
