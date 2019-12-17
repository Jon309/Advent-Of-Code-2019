using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using AdventOfCode._2019.Day2;

namespace AdventOfCode._2019.UnitTests
{
    [TestFixture]
    public class DayTwoTests
    {
        [Test]
        public void PartOneAnswerTest()
        {
            var opcodes = 
                new StreamReader("/Users/henny/dev/Advent.Of.Code.2019/AdventOfCode.2019.Day2/input.txt")
                    .ReadToEnd();
            
            var output = 2894520;
            
            var intCode = new IntCode(opcodes);
            
            intCode.Relocate(1, 12);
            intCode.Relocate(2,2);
            intCode.Start();
            
            Assert.AreEqual(output,intCode.GetValue(0));
        }
        
        [Test]
        public void PartTwoAnswerTest()
        {
            var opcodes = 
                new StreamReader("/Users/henny/dev/Advent.Of.Code.2019/AdventOfCode.2019.Day2/input.txt")
                    .ReadToEnd();
            
            var output = 2894520;
            
            var intCode = new IntCode(opcodes);
            
            intCode.Relocate(1, 12);
            intCode.Relocate(2,2);
            intCode.Start();
            
            Assert.AreEqual(output,intCode.GetValue(0));
        }
        
        [Test]
        public void ParseInputTest()
        {
            var opcodes = "1,9,10,3,2,3,11,0,99,30,40,50";
            
            var intCode = new IntCode(opcodes);
            
            Assert.AreEqual(opcodes, intCode.GetOpcodes());
        }

        [Test]
        public void SampleOneTest()
        {
            var opcodes = "1,0,0,0,99";
            var output = 2;
            
            var intCode = new IntCode(opcodes);
            
            intCode.Start();
            
            Assert.AreEqual(2,intCode.GetValue(0));
        }
        
        [Test]
        public void SampleTwoTest()
        {
            var opcodes = "2,3,0,3,99";
            var output = "2,3,0,6,99";
            
            var intCode = new IntCode(opcodes);
            
            intCode.Start();
            
            Assert.AreEqual(output, intCode.GetOpcodes());
        }
        
        [Test]
        public void SampleThreeTest()
        {
            var opcodes = "2,4,4,5,99,0";
            var output = "2,4,4,5,99,9801";
            
            var intCode = new IntCode(opcodes);
            
            intCode.Start();
            
            Assert.AreEqual(output, intCode.GetOpcodes());
        }
        
        [Test]
        public void SampleFourTest()
        {
            var opcodes = "1,1,1,4,99,5,6,0,99";
            var output = "30,1,1,4,2,5,6,0,99";
            
            var intCode = new IntCode(opcodes);
            
            intCode.Start();
            
            Assert.AreEqual(output, intCode.GetOpcodes());
        }
    }
}