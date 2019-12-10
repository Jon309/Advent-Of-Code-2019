using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Advent.Of.Code._2019._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var massList = new List<int>();
            
            StreamReader input = 
                new StreamReader("/Users/henny/dev/Advent.Of.Code.2019/Advent.Of.Code.2019/input.txt");

            while (!input.EndOfStream)
            {
                int mass;
                if (int.TryParse(input.ReadLine(), out mass))
                    massList.Add(mass);
            }
            
            var fuelCounter = new FuelCounter();
            var totalFuel = fuelCounter.CalculateFuel(massList);

            Console.WriteLine("Total Fuel Needed: " + totalFuel);
        }
    }
}