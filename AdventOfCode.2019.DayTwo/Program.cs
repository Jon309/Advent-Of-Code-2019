using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace AdventOfCode._2019.DayTwo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Run();
        }

        private static void Run()
        {
            var opcodes = 
                new StreamReader("/Users/henny/dev/Advent.Of.Code.2019/AdventOfCode.2019.DayTwo/input.txt")
                    .ReadToEnd();

            var intCode = new IntCode(opcodes);
            
            intCode.Relocate(1, 12);
            intCode.Relocate(2,2);
            intCode.Start();
            
            Console.WriteLine($"Value at index {0}: {intCode.GetValue(0)}");
        }
        
    }    
}