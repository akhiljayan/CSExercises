using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would convert temperature given in Centigrade 
    //scale to Fahrenheit – the number can be integer or real.  Use the formula:
    //	F = 1.8C  + 32

    public class ExB4
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the temprature in Centigrade: ");
            string tempStr = Console.ReadLine();
            double tempIncentigrade = Convert.ToDouble(tempStr);
            double result = ConvertToFahrenheit(tempIncentigrade);
            Console.WriteLine("\nTemprature in Fahrenheit: {0:0.###}", result);
        }

        public static double ConvertToFahrenheit(double c)
        {
            //YOUR CODE HERE - convert celcius to fahrenheit
            double Far = ((1.8 * c) + 32);
            return Far;

        }
    }
}
