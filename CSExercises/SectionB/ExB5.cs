using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would take as input the 
    //value of x and calculate & output the value 
    //of y using the formula:
    // y = 5 x2 – 4 x + 3

    public class ExB5
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter value of 'x': ");
            string xStr = Console.ReadLine();
            double xDble = Convert.ToDouble(xStr);
            double result = CalculateY(xDble);
            Console.WriteLine("\nValue of (5x^2-4x+3) = y = {0}", result);
        }

        public static double CalculateY(double x)
        {
            double y = (5 * (Math.Pow(x, 2)) - (4 * x) + 3);
            return y;
        }
    }
}
