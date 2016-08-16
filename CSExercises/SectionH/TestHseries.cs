using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.SectionH
{
    class TestHseries
    {
        public static void Main()
        {
            //Console.Write("Enter 1st Sentence (s1):\t");
            //string s1 = Console.ReadLine();
            //Console.Write("Enter word (s2):\t");
            //string s2 = Console.ReadLine();
            //Console.WriteLine(ExH1.InString(s1, s2));

            //Console.WriteLine(ExH2.FindWord(s1, s2));

            //Console.Write("Enter number:\t");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(ExH3.Hex(a));

            Console.Write("Enter string (s1):\t");
            string s1 = Console.ReadLine();

            Console.Write("Enter char to replace:\t");
            char c1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter new character:\t");
            char c2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(ExH4.Substitute(s1, c1, c2));

        }
    }
}
