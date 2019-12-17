using System;
using System.Collections.Generic;
using System.IO;
using AdventOfCode._2019.Day1;
using NUnit.Framework;

namespace AdventOfCode._2019.UnitTests
{
    public class DayOneTests
    {

        [Test]
        public void DayOnePartOneTest()
        {
            var massList = new List<int>();
            
            StreamReader input = 
                new StreamReader("/Users/henny/dev/Advent.Of.Code.2019/AdventOfCode.2019.Day1/input.txt");

            while (!input.EndOfStream)
            {
                int mass;
                if (int.TryParse(input.ReadLine(), out mass))
                    massList.Add(mass);
            }
            
            IFuelCounter fuelCounter = new FuelCounter();

            var fuel = 0;

            foreach (var mass in massList)
            {
                fuel += fuelCounter.CalculateFuel(mass);
            }
            
            Assert.AreEqual(3233481, fuel);
        }

        [Test]
        public void DayOnePartTwoTest()
        {
            var massList = new List<int>();
            
            StreamReader input = 
                new StreamReader("/Users/henny/dev/Advent.Of.Code.2019/AdventOfCode.2019.Day1/input.txt");

            while (!input.EndOfStream)
            {
                int mass;
                if (int.TryParse(input.ReadLine(), out mass))
                    massList.Add(mass);
            }
            
            IFuelCounter fuelCounter = new FuelCounter();
            Assert.AreEqual(4847351, fuelCounter.SumAllFuel(massList));
        }


    }
}