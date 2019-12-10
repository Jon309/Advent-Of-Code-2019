using System.Collections.Generic;

namespace Advent.Of.Code._2019._1
{
    public class FuelCounter : IFuelCounter
    {
        private int _totalFuel;
        private int _fuelSum;

        public int CalculateFuel(int mass)
        {
            return (mass / 3) - 2;
        }

        public int CalculateTotalFuel(int mass)
        {
            if (mass > 0)
            {
                var fuel = CalculateFuel(mass);
                if (fuel > 0)
                {
                    _totalFuel += fuel;
                    CalculateTotalFuel(fuel); 
                }
            }
            return _totalFuel;
        }

        public int SumAllFuel(List<int> massList)
        {
            _fuelSum = 0;
            foreach (var mass in massList)
            {
                var fuel = CalculateTotalFuel(mass);
                _fuelSum += fuel;
                _totalFuel = 0;
            }
            return _fuelSum;
        }

    }
}