using System.Linq;

namespace Day1
{
    public class DepthChecker
    {
        public static int SonarSweep(int[] inputArray)
        {
            var count = 0;
            var previousInput = inputArray.First();
            foreach (var depth in inputArray)
            {
                if (depth > previousInput) count++;
                previousInput = depth;
            }

            return count;
        }

        public static int SummedSonarSweep(int[] inputArray)
        {
            var count = 0;
            var previousSum = inputArray.Take(3).Sum(x => x);
            
            for (var i = 3; i < inputArray.Length; i++)
            {
                var sum = inputArray[i] + inputArray[i - 1] + inputArray[i - 2];
                if (sum > previousSum) count++;
                previousSum = sum;
            }

            return count;
        }
    }
}