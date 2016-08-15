using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            Console.Write("Input: ");
            string inputString = Console.ReadLine();
            double doubleNumb = Convert.ToDouble(inputString);
            double result = SQRT(doubleNumb);
            Console.WriteLine("\nOutput: {0:0.000}", result);
        }

        public static double SQRT(double x)
        {
            double y = Math.Sqrt(x);
            return y;

        }
    }
}
