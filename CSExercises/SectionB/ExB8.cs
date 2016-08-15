using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the distance traveled: ");
            string distanceStr = Console.ReadLine();
            double distDble = Convert.ToDouble(distanceStr);
            double fare = CalculateFare(distDble);
            Console.WriteLine("\nTotal fare = ${0:0.00}", fare);
        }

        public static double CalculateFare(double distance)
        {
            double totalFare = ((double)2.40 + (distance * (double)0.40));
            double roundedFare = Math.Round(totalFare * 20) / 20;
            return roundedFare;
        }
    }
}
