using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to batting average calculator!");
            Console.WriteLine();
            Console.WriteLine("Enter number of times at bat:");
            int numBats = int.Parse(Console.ReadLine());
            int[] batting = new int[numBats];

            //--------------------------------------------------

            for (int i = 0; i <= batting.Length - 1; i++)
            {
                Console.WriteLine("Please enter a result for bat No." + (i + 1));
                batting[i] = int.Parse(Console.ReadLine());
            }

            double sluggingPercent = 0;
            double sum = 0;

            for (int i = 0; i <= batting.Length - 1; i++)
            {
                sum = sum + batting[i];

            }

            sluggingPercent = sum / numBats;
            Console.WriteLine($"Slugging Percentage: {sluggingPercent}");

            double battingAvg = 0;
            double count = 0;

            for (int i = 0; i <= batting.Length - 1; i++)
            { 
            if (batting[i] != 0)
            {
                count = count + 1;
            }
        }
            battingAvg = count / numBats;
            Console.WriteLine($"Batting Average: {battingAvg}");
        }
    }
}
