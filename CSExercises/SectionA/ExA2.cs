﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{

    //2.	Write a program that would request for your name and print a greeting like this:
    // 		Good Morning John
    //      where John is the name you had input.


    public class ExA2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your name:");
            string name = Console.ReadLine();
            Console.WriteLine("\nGood Morning {0}", name);
        }
    }
}
