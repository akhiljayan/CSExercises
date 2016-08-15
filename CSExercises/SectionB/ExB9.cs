using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
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
            double roundedFare = Math.Ceiling(totalFare * 10) / 10;
            return roundedFare;
        }
    }
}
