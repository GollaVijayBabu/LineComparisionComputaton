using System;

namespace ComparisonComputation
{
    class UC_1
    {
        public double X1, X2, Y1, Y2;
        public double lengthOfLine;

        public void CalculateLengthOfLine()
        {
            Console.WriteLine("Enter the values of X1 , Y1 ");
            X1 = Convert.ToInt32(Console.ReadLine());
            Y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the values of X2 , Y2 ");
            X2 = Convert.ToInt32(Console.ReadLine());
            Y2 = Convert.ToInt32(Console.ReadLine());

            lengthOfLine = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine("Length of Line is: " + lengthOfLine);
        }
    }
}
