using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace AdventOfCode._2019.DayTwo 
{ 
    public class IntCode : IIntCode
    {
        private List<int> _opcodes;

        public IntCode(string opcodes)
        {
            _opcodes = ParseInput(opcodes);
        }

        public string GetOpcodes()
        {
            return string.Join(",", _opcodes);
        }

        public List<int> ParseInput(string input) 
        {  
            return Array.ConvertAll( 
                input.Split(','), int.Parse).ToList(); 
        }

        public void Start()
        {
            Process();
        }

        private void Process()
        {
            for(var i = 3; i< _opcodes.Count - 1; i++)
            {
                if ((i + 1) % 4 == 0)
                {
                    var operation = GetInstruction(_opcodes[i - 3]);
                    
                    if (operation == Operations.Halt)
                    {
                        return;
                    }
                    
                    var x = GetValue(_opcodes[i - 2]);
                    var y = GetValue(_opcodes[i - 1]);
                
                    Relocate(_opcodes[i], Operate(x,y,operation));
                }
            }
        }

        public Operations GetInstruction(int number)
        {
            switch (number)
            {
                case 1:
                    return Operations.Add;
                case 2:
                    return Operations.Multiply;
                case 99:
                    return Operations.Halt;
                default:
                    return Operations.Halt;
            }
        }
        
        public int Operate(int x, int y, Operations operation)
        {
            switch (operation)
            {
                case Operations.Add:
                    return x + y;
                case Operations.Multiply:
                    return x * y;
                case Operations.Halt:
                    return -1;
                default:
                    return -1;
            }
        }

        public void Relocate(int index, int value)
        {
            _opcodes[index] = value;
        }

        public int GetValue(int index)
        {
            return _opcodes[index];
        }

    } 
}