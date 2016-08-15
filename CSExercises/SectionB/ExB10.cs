using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            Console.Write("Enter the 1st side length (a): ");
            string aStr = Console.ReadLine();
            Console.Write("\nEnter the 2st side length (b): ");
            string bStr = Console.ReadLine();
            Console.Write("\nEnter the 3st side length (c): ");
            string cStr = Console.ReadLine();

            double aDble = Convert.ToDouble(aStr);
            double bDble = Convert.ToDouble(bStr);
            double cDble = Convert.ToDouble(cStr);

            double area = CalculateArea(aDble, bDble, cDble);
            if (area == -1)
            {
                Console.WriteLine("\nArea cannot be defined!!!");
            }
            else
            {
                Console.WriteLine("\nArea = {0:0.##}", area);
            }

        }

        public static double CalculateArea(double a, double b, double c)
        {
            double s = ((a + b + c) / (double)2);
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            if (!Double.IsNaN(area))
            {
                return area;
            }
            else
            {
                return -1;
            }

        }
    }
}