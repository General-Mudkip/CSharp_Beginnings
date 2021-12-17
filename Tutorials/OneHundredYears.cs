using System;

namespace Tutorials
{
    class OneHundredYears
    {
        public static void OneHundred()
        {
            Console.WriteLine("Enter your current age.");
            string age = Console.ReadLine();
            int age_int = int.Parse(age);
            
            Console.WriteLine("You will turn 100 in the year {0}", 2021+(100-age_int));
        }
    }
}