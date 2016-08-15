using System;

namespace CSExercises
{
    //Write a program that would request for your name and gender (M or F assume capital letter) and print a greeting like this:
    //Good Morning Mr.Venkat
    //where you entered Venkat for name and M for gender.

    public class ExC1
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("\nPlease enter your gender (M/F): ");
            string gender = Console.ReadLine();

            if (gender == "M" || gender == "m")
            {
                Console.WriteLine("\nGood Morning Mr.{0}", name);
            }
            else if (gender == "F" || gender == "f")
            {
                Console.WriteLine("\nGood Morning Mrs.{0}", name);
            }
        }
    }
}