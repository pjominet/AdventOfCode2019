using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    public static class Challenge2
    {
        public static int Part1()
        {
            return 0;
        }

        public static int Part2()
        {
            return 0;
        }
        
        private static IEnumerable<int> GetInputData()
        {
            var inputData = new List<int>();
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "c2.txt");

            if (!File.Exists(filePath))
                throw new FileNotFoundException();

            string line;
            var reader = new StreamReader(filePath);
            while ((line = reader.ReadLine()) != null)
            {
                inputData.AddRange(line.Split(',').Select(int.Parse));
            }

            return inputData;
        }
    }
}