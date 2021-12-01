using AdventOfCode.Utils;
using System;

namespace AdventOfCode.Day_01
{
    class Day01
    {
        private string input;

        public Day01(string input)
        {
            this.input = input;
        }

        public void Run()
        {
            var data = FileReader.InputAsArray(input);

            // Part 1
            int prevDepth = int.Parse(data[0]);
            int higherCounter = 0;

            for (int row = 1; row < data.Length; row++)
            {
                // parse to int
                var newDepth = int.Parse(data[row]);

                // check if previous is smaller
                if (prevDepth < newDepth)
                {
                    higherCounter++;
                }

                prevDepth = newDepth;
            }

            Console.WriteLine("Higher Count: " + higherCounter);

            // Part 2
            int i = 1;
            int prevDepthSum = int.Parse(data[0]) + int.Parse(data[1]) + int.Parse(data[2]);
            int higherCounterWihtSum = 0;

            for (int row = 1; row+2 < data.Length; row ++)
            {
                // parse to int
                var newDepthSum = int.Parse(data[row]) + int.Parse(data[row + 1]) + int.Parse(data[row + 2]);

                // check if previous is smaller
                if (prevDepthSum < newDepthSum)
                {
                    higherCounterWihtSum++;
                }

                prevDepthSum = newDepthSum;
            }

            Console.WriteLine("Higher Count with Sum: " + higherCounterWihtSum);
        }
    }
}
