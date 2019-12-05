using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    public static class Challenge1
    {
        public static int Part1()
        {
           return GetInputData().Sum(capacity => (capacity / 3) - 2);
        }

        public static int Part2()
        {
            return GetInputData().Sum(capacity => FuelAmountRecursive(capacity));
        }
        
        private static IEnumerable<int> GetInputData()
        {
            var inputData = new List<int>();
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "c1.txt");

            if (!File.Exists(filePath))
                throw new FileNotFoundException();

            string line;
            var reader = new StreamReader(filePath);
            while ((line = reader.ReadLine()) != null)
            {
                inputData.Add(int.Parse(line));
            }

            return inputData;
        }

        private static int FuelAmountRecursive(int capacity, int fuel = 0)
        {
            var next = capacity / 3 - 2;
            return next < 0 ? fuel : FuelAmountRecursive(next, fuel + next);

        }
    }
}