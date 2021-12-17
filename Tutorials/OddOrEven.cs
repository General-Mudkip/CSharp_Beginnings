﻿using System;

namespace Tutorials
{
    public class OddOrEven
    {
        public static void OddEven()
        {
            Console.WriteLine("Enter an integer.");
            try
            {
                string string_input = Console.ReadLine();
                int int_input = Int32.Parse(string_input);

                if (int_input % 2 == 0)
                {
                    Console.WriteLine("Your number is even.");
                }
                else
                {
                    Console.WriteLine("Your number is odd.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a number!");
            }
        }
    }
}