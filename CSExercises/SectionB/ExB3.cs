using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            Console.Write("Specify the salary: ");
            string salStr = Console.ReadLine();

            double[] result = CalculateIncome(salStr);
            Console.WriteLine("\nBasic Salary: ${0:#,###.00}\nHousing Allowance: ${1:#,##0.00}\nTransport Allowance: ${2:#,##0.00}\n--------------------------------\nTotal: ${3:#,###.00}", result[0], result[1], result[2], result[3]);
        }

        public static double[] CalculateIncome(string salaryStr)
        {
            double salDouble = Convert.ToDouble(salaryStr);
            double housingAlowance = ((double)10 / 100) * salDouble;
            double transportAlowance = ((double)3 / 100) * salDouble;
            double total = (salDouble + housingAlowance + transportAlowance);
            double[] result = new double[] { salDouble, housingAlowance, transportAlowance, total };
            return result;
        }
    }
}
