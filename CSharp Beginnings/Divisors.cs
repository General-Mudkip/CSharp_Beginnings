using System;
using System.Collections.Generic;
using System.Linq;

namespace Tutorials
{
    public class Divisors
    {
        public static bool FindDivisors()
        {
            Console.WriteLine("Enter a number to find the divisors of.");
            try
            {
                string user_input = Console.ReadLine();
                int num_input = Int32.Parse(user_input);

                int divisor = 0;
                List<int> divisors = new List<int>();

                while (divisor < (num_input / 2))
                {
                    divisor++;
                    if (divisors.Contains(divisor)) { continue; }
                    
                    if (num_input % divisor == 0)
                    {
                        divisors.Add(divisor);
                        if (divisor != num_input / divisor) { divisors.Add(num_input/divisor); }
                    }
                }
                
                foreach (int item in divisors)
                {
                    Console.WriteLine(item);
                }
                
                return true;
            }
            catch (FormatException)
            {
                return true;
            }
            
            return true;
        }
    }
}