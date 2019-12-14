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
            
            
            //Part Two
            int noun;
            int verb;
            
            for (var i = 0; i < 99; i++)
            {
                for (var j = 0; j < 99; j++)
                {
                    //Initialize for Part Two
                    var intCode = new IntCode(opcodes);
                    
                    intCode.Relocate(1, i);
                    intCode.Relocate(2,j);
                    intCode.Start();

                    if (intCode.GetValue(0) == 19690720)
                    {
                        noun = i;
                        verb = j;
                        
                        Console.WriteLine($"Noun: {noun}");
                        Console.WriteLine($"Verb: {verb}");
                        Console.WriteLine($"Answer: {100 * noun + verb}");
                    }
                }
            }
            
            //Part One
            //Console.WriteLine($"Value at index {0}: {intCode.GetValue(0)}");
        }
    }    
}