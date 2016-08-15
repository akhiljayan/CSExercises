using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter x cordinate of 1st pont P1 (x1): ");
            string x1Str = Console.ReadLine();
            Console.Write("\nEnter y cordinate of 1st pont P1 (y1): ");
            string y1Str = Console.ReadLine();
            Console.Write("\nEnter x cordinate of 1st pont P2 (x2): ");
            string x2Str = Console.ReadLine();
            Console.Write("\nEnter y cordinate of 1st pont P2 (y2): ");
            string y2Str = Console.ReadLine();

            double x1Dble = Convert.ToDouble(x1Str);
            double y1Dble = Convert.ToDouble(y1Str);
            double x2Dble = Convert.ToDouble(x2Str);
            double y2Dble = Convert.ToDouble(y2Str);

            double distance = CalculateDistance(x1Dble, y1Dble, x2Dble, y2Dble);
            Console.WriteLine("\nDistance  = {0}", distance);


        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double inner = (Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2));
            double finalDistance = Math.Sqrt(inner);
            return finalDistance;
        }
    }
}
