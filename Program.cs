using System;
using System.Collections.Generic;
using System.Linq;

namespace random
{
    class Program
    {

        public static void Display(List<int> list)
            {
                string listString = string.Join(", ", list);
                System.Console.WriteLine(listString);
            }
        static void Main(string[] args)
        {
            Random Ran = new Random();

            List<int> RandomNumbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                RandomNumbers.Add(Ran.Next(1, 51));
            }
            List<int> RandomSquares = (
                from number in RandomNumbers
                select number * number
            ).ToList();
            List<int> EvenSquares = (
                from square in RandomSquares
                where square % 2 == 0
                select square
            ).ToList();

            System.Console.WriteLine("All squares: ");
            Program.Display(RandomSquares);
            System.Console.WriteLine("Even Squares: ");
            Program.Display(EvenSquares);

        }
    }
}
