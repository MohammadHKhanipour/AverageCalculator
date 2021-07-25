using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageCalculator
{
    class Program
    {
        static double averageCalculator(List<Subject> list)
        {
            double markTemp = 0;
            int mulTemp = 0;

            foreach (var item in list)
            {
                markTemp += item.Mark * item.Mul;
                mulTemp += item.Mul;
            }

            return markTemp / mulTemp;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Subject's 'Name' 'Score' and 'Mul' Respectively One Space Apart\nType 'Exit' When You're Done\n");
            Console.WriteLine("Enter 'Name' 'Score' and 'Mul' and Type 'Exit' When You're Done\n");

            string input;
            string[] temp;

            string name;
            double mark;
            int mul;

            List<Subject> subjects = new List<Subject>();

            while ((input = Console.ReadLine()) != "Exit")
            {
                temp = input.Split(' ');
                name = temp[0];
                mark = Convert.ToDouble(temp[1]);
                mul = Convert.ToInt32(temp[2]);

                Subject subject = new Subject(name, mark, mul);
                subjects.Add(subject);
            }

            var average = averageCalculator(subjects);

            Console.Clear();

            if (average > 17)
                Console.WriteLine($"\n\tAverage:\t\t{average.ToString("0.00")} *Privileged*");
            else
                Console.WriteLine($"\n\tAverage:\t\t{average.ToString("0.00")}");

            var maxScore = subjects.Max(x => x.Mark);
            Console.WriteLine($"\n\tHighest Score:\t\t{maxScore.ToString("0.00")} \t ({subjects.FirstOrDefault(x => x.Mark == maxScore).Name})");

            var minScore = subjects.Min(x => x.Mark);
            Console.WriteLine($"\tLowest Score:\t\t{minScore.ToString("0.00")} \t ({subjects.FirstOrDefault(x => x.Mark == minScore).Name})");

            Console.WriteLine($"\n\tNum of Subjects:\t{subjects.Count}");
            Console.WriteLine($"\tPerfect Scores (20/20):\t{subjects.Count(x => x.Mark == 20)}");
            Console.WriteLine($"\tScores Higher Than 17:\t{subjects.Count(x => x.Mark > 17)}");
            Console.WriteLine($"\tFailed Subject(s):\t{subjects.Count(x => x.Mark < 10)}");

            foreach (var item in subjects)
            {
                if (item.Mark < 10)
                    Console.WriteLine($"\t\t{item.Name}");
            }

        }
    }
}
