using System;

namespace ComparisonComputation
{
    class UC_2
    {
        public double X1, X2, Y1, Y2, X3, Y3, X4, Y4;
        public double LengthOfLine1;
        public double LengthOfLine2;

        public void EqualityofLines()
        {
            Console.WriteLine("Enter the values of X1 , Y1");
            X1 = Convert.ToInt32(Console.ReadLine());
            Y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the values of X2 , Y2");
            X2 = Convert.ToInt32(Console.ReadLine());
            Y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the values of X3 , Y3");
            X3 = Convert.ToInt32(Console.ReadLine());
            Y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the values of X4 , Y4 ");
            X4 = Convert.ToInt32(Console.ReadLine());
            Y4 = Convert.ToInt32(Console.ReadLine());

            LengthOfLine1 = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            LengthOfLine2 = Math.Sqrt(Math.Pow(X4 - X3, 2) + Math.Pow(Y4 - Y3, 2));

            Console.WriteLine("Length of Line1 is: " + LengthOfLine1);
            Console.WriteLine("Length of Line2 is: " + LengthOfLine2);

            if (LengthOfLine1 == LengthOfLine2)
            {
                Console.WriteLine("Length of two lines are equal");
            }
            else
            {
                Console.WriteLine("Length of two lines are not equal");
            }
        }
    }
}
