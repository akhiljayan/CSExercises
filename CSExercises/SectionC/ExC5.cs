using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a 3 digit number: ");
            string number = Console.ReadLine();
            bool result = IsArmstrongNumber(number);
            Console.WriteLine(result);
        }


        public static bool IsArmstrongNumber(string n)
        {
            int number = Convert.ToInt32(n);
            var charArray = n.ToCharArray();
            int a = Convert.ToInt32(Convert.ToString(charArray[0]));
            int b = Convert.ToInt32(Convert.ToString(charArray[1]));
            int c = Convert.ToInt32(Convert.ToString(charArray[2]));

            double amstrung = (long)Math.Pow(a, 3) + (long)Math.Pow(b, 3) + (long)Math.Pow(c, 3);
            int finalInt = Convert.ToInt32(amstrung);

            if (finalInt == number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}