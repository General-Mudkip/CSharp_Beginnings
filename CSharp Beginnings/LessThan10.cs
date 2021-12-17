using System;

namespace Tutorials
{
    public class LessThan10
    {
        public static bool LessThan()
        {
            double[] doubles = new[] {1.0,2.0,3.0,4.0,5.0,6.0,7.0,8.0,9.0,10.0};

            foreach (double num in doubles)
            {
                if (num < 5)
                {
                    Console.Write("{0}, ", num);
                }
            }
            
            return false;
        }
    }
}