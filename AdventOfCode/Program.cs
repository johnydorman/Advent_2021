using System;
using AdventOfCode.Day_01;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             */
            Console.WriteLine("Advent of Code 2021");


            /*
             * 
             */
            int day = 1;

            Console.WriteLine("Running Day " + day);
            RunDay(day);

            /*
            for (int i = 1; i < 25; i++) {

                Console.WriteLine("Running Day " + day);
                RunDay(1);
            }
            */
        }

        private static void RunDay(int day)
        {
            switch (day)
            {
                case 1:
                    Day01 day01 = new Day01("day01_input.txt");
                    day01.Run();
                    break;


                default:
                    break;
            }

            return;
        }
    }
}
