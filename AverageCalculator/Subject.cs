using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCalculator
{
    public class Subject
    {
        public Subject(string name, double mark, int mul)
        {
            Name = name;
            Mark = mark;
            Mul = mul;
        }

        public string Name { get; set; }
        public double Mark { get; set; }
        public int Mul { get; set; }
    }
}
