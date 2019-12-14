using System.Collections.Generic;

namespace AdventOfCode._2019.DayOne
{
    public interface IFuelCounter
    {
        int CalculateFuel(int mass);
        int CalculateTotalFuel(int mass);
        int SumAllFuel(List<int> massList);
    }
}