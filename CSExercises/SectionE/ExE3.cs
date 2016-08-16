using System;

namespace CSExercises
{
    public class ExE3
    {
        //Given an integer as input determine whether the number 
        //is a prime number or not.  Your program should output “Prime” 
        //    or “Not Prime” as the case may be.

        //A Prime Number is one which is only divisible by one and itself.

        //Consider how the efficiency of the program can be improved. 
        //Normally the order of complexity is proportional to the number of 
        //    times a loop is executed.A more formal definition of 
        //    “Analysis of Algorithms” will be dealt in a later course.

        public static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());


            if (IsPrime(n))
            {
                Console.WriteLine("Number is a Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }

        public static bool IsPrime(int n)
        {
            if (n == 1 || n % 2 == 0 && n != 2)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }  

            for (int i = 3; i < n; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPrimeAnotherWay(int n)
        {
            bool isPrime = true;
            for(int i = 0; i< n-1; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;// once "if" condition satisfy breaks from loop or just "return false"
                }
            }
            return isPrime;
        }
    }
}
