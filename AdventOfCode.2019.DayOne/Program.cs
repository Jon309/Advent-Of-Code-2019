using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode._2019.DayOne
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var massList = new List<int>();
            
            StreamReader input = 
                new StreamReader("/Users/henny/dev/Advent.Of.Code.2019/AdventOfCode.2019.DayOne/input.txt");

            while (!input.EndOfStream)
            {
                int mass;
                if (int.TryParse(input.ReadLine(), out mass))
                    massList.Add(mass);
            }
            
            var fuelCounter = new FuelCounter();

            Console.WriteLine("Total Fuel Needed: " + fuelCounter.SumAllFuel(massList));
        }
    }
}