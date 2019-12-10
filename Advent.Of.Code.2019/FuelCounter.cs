using System.Collections.Generic;

namespace Advent.Of.Code._2019._1
{
    public class FuelCounter : IFuelCounter
    {
        public int CalculateFuel(List<int> massList)
        {
            var totalFuel = 0;

            foreach (var mass in massList)
            {
                totalFuel += (mass / 3) - 2;
            }

            return totalFuel;
        }

    }
}