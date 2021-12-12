using System.IO;
using System.Linq;
using NUnit.Framework;

namespace Day1
{
    [TestFixture]
    public class Day1Tests
    {
        private readonly int[] _inputArray = { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };
        private const string CodeWarsInputFilePath = @"../../../Day1Input";
        
        [Test]
        public void TestThatCountOfIncreasedDepthIsAccurateFromSonarSweep()
        {
            var depthCheckerResponse = DepthChecker.SonarSweep(_inputArray);
            
            Assert.AreEqual(7, depthCheckerResponse);
        }
        
        [Test]
        public void TestInputAndResponseFromCodeWarsFileIntoSonarSweep()
        {
            var input = File.ReadAllLines(CodeWarsInputFilePath).Select(int.Parse).ToArray();
            
            var depthCheckerResponse = DepthChecker.SonarSweep(input);
            Assert.AreEqual(1713, depthCheckerResponse);
        }

        [Test]
        public void TestThatSumOfSlidingWindowIsExpectedFromSummedSonarSweep()
        {
            var summedResponse = DepthChecker.SummedSonarSweep(_inputArray);
            
            Assert.AreEqual(5, summedResponse);
        }

        [Test]
        public void TestThatSumOfCodeWarsInputIsCorrectFromSummedSonarSweep()
        {
            var input = File.ReadAllLines(CodeWarsInputFilePath).Select(int.Parse).ToArray();
            
            var summedResponse = DepthChecker.SummedSonarSweep(input);
            Assert.AreEqual(1734, summedResponse);
        }
    }
}