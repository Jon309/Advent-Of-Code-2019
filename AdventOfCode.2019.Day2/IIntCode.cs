using System.Collections.Generic;

namespace AdventOfCode._2019.Day2
{
    public interface IIntCode
    {
        List<int> ParseInput(string input);
        void Start();
        Operations GetInstruction(int number);
        int Operate(int x, int y, Operations operation);
    }
}