using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that will takes an integer as input and prints the square of that number
    //For this exercise, the input and output has been implemented for you in the template
    //You need to implement the square function

    public class ExA3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter a number: ");
            string inputString = Console.ReadLine();
            int inputInt = Convert.ToInt32(inputString);

            int result = square(inputInt);

            Console.WriteLine("\nThe square of {0} is {1}", inputInt, result);
        }

        public static int square(int x)
        {
            int y = x * x;
            return y;
        }
    }
}
