using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Day3
{
    [TestFixture]
    public class Day3Tests
    {
        private readonly string[] _inputBinaries = new[] { "00100", "11110", "10110", "10111", "10101", "01111", "00111", "11100", "10000", "11001", "00010", "01010" };
        private readonly string _gammaRateBinaryString = "10110";
        private readonly string _epsilonRateBinaryString = "01001";
        private const string CodeWarsInputFilePath = @"../../../Input.txt";
        
        [Test]
        public void TestThatGammaBitIsCalculatedCorrectly()
        {
            var response = BinaryDiagnostics.GetGammaRateBinaryString(_inputBinaries);
            
            Assert.AreEqual(_gammaRateBinaryString,response);
        }

        [Test]
        public void TestThatEpsilonRateIsCalculatedCorrectly()
        {
            var response = BinaryDiagnostics.GetEpsilonRateBinaryString(_gammaRateBinaryString);
            
            Assert.AreEqual("01001", response);
        }

        [Test]
        public void TestThatWhenGivenGammaAndEpsilonBinaryStringsPowerConsumptionCalculatesCorrectly()
        {
            var response = BinaryDiagnostics.CalculatePowerConsumption(_gammaRateBinaryString, _epsilonRateBinaryString);
            
            Assert.AreEqual(198, response);
        }

        // [Test]
        // public void TestThatCodeWarsInputIsCalculatedCorrectly()
        // {
        //     var inputArray = File.ReadLines(CodeWarsInputFilePath).ToArray();
        //     var gammaRateBinaryString = BinaryDiagnostics.GetGammaRateBinaryString(inputArray);
        //     var epsilonRateBinaryString = BinaryDiagnostics.GetEpsilonRateBinaryString(gammaRateBinaryString);
        //
        //     var response = BinaryDiagnostics.CalculatePowerConsumption(gammaRateBinaryString, epsilonRateBinaryString);
        //     
        //     Assert.AreEqual("TBC", response);
        // }
    }

    public class BinaryDiagnostics
    {
        public static string GetGammaRateBinaryString(string[] inputBinaries)
        {
            var column1 = new List<string>();
            var column2 = new List<string>();
            var column3 = new List<string>();
            var column4 = new List<string>();
            var column5 = new List<string>();
            

            foreach (var binary in inputBinaries)
            {
                column1.Add(binary.ToCharArray(0,1).First().ToString());
                column2.Add(binary.ToCharArray(1,1).First().ToString());
                column3.Add(binary.ToCharArray(2,1).First().ToString());
                column4.Add(binary.ToCharArray(3,1).First().ToString());
                column5.Add(binary.ToCharArray(4,1).First().ToString());
            }

            var commonBinaryArray = new List<string>
            {
                column1.Count(x => x == "1") > column1.Count(x => x == "0") ? "1" : "0",
                column2.Count(x => x == "1") > column2.Count(x => x == "0") ? "1" : "0",
                column3.Count(x => x == "1") > column3.Count(x => x == "0") ? "1": "0",
                column4.Count(x => x == "1") > column4.Count(x => x == "0") ? "1": "0",
                column5.Count(x => x == "1") > column5.Count(x => x == "0") ? "1": "0"
            };

            return string.Join("", commonBinaryArray);
        }

        public static string GetEpsilonRateBinaryString(string gammaRateBinaryString)
        {
            var binaryList = gammaRateBinaryString.ToCharArray().Select(character => character == '1' ? "0" : "1").ToList();
            return string.Join("", binaryList);
        }

        public static decimal CalculatePowerConsumption(string gammaRateBinaryString, string epsilonRateBinaryString)
        {
            var gammaRate = Convert.ToInt32(gammaRateBinaryString, 2);
            var epsilonRate = Convert.ToInt32(epsilonRateBinaryString, 2);
            return gammaRate * epsilonRate;
        }
    }
}