using System;
using System.Collections.Generic;
using System.IO;
using Advent.Of.Code._2019._1;
using NUnit.Framework;

namespace AdventOfCode._2019.UnitTests
{
    [TestFixture]
    public class Tests
    {
        [PreTest]
        public List<int> Initialize()
        {
            var massList = new List<int>();
            
            StreamReader input = 
                new StreamReader("/Users/henny/dev/Advent.Of.Code.2019/AdventOfCode.2019/input.txt");

            while (!input.EndOfStream)
            {
                int mass;
                if (int.TryParse(input.ReadLine(), out mass))
                    massList.Add(mass);
            }

            return massList;
        }
        
        [Test]
        public void DayOnePartOneTest()
        {
            var massList = Initialize();
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
            var massList = Initialize();
            IFuelCounter fuelCounter = new FuelCounter();
            Assert.AreEqual(4847351, fuelCounter.SumAllFuel(massList));
        }
        
    }
}