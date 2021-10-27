using System;

namespace ComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Comparison Computation Program");

            UC_1 length = new UC_1();
            length.CalculateLengthOfLine();

            UC_2 equal = new UC_2();
            equal.EqualityofLines();

            UC_3 comparison = new UC_3();
            comparison.ComparisonOfLines();

            UC_4 uc = new UC_4();
            uc.ComparisonOfLines();
        }
    }
}

