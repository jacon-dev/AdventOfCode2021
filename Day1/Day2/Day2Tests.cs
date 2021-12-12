using System;
using System.IO;
using NUnit.Framework;

namespace Day2
{
    [TestFixture]
    public class Day2Tests
    {
        private readonly string[] _inputDirections = { "forward 5", "down 5", "forward 8", "up 3", "down 8", "forward 2" };
        private const string CodeWarsInputFilePath = @"../../../Day2Input";

        [Test]
        public void TestThatSubmarineMovesAsExpected()
        {
            var response = SubmarineControls.MoveSubmarine(_inputDirections);
            
            Assert.AreEqual(150, response);
        }

        [Test]
        public void TestThatSubmarineMovesAsExpectedUsingCodeWarsInput()
        {
            var inputDirections = File.ReadAllLines(CodeWarsInputFilePath);
            
            var response = SubmarineControls.MoveSubmarine(inputDirections);
            
            Assert.AreEqual(1427868, response);
        }

        [Test]
        public void TestThatAimingTheSubmarineWorksAsExpected()
        {
            var response = SubmarineControls.AimSubmarine(_inputDirections);
            
            Assert.AreEqual(900, response);
        }
    }
}