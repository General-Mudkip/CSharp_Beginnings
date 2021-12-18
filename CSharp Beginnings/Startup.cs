using System;

namespace Tutorials
{
    public class Startup
    {
        private static void Main()
        {
            bool do_loop;
            do
            {
                //do_loop = OneHundredYears.OneHundred();
                //do_loop = OddOrEven.OddEven();
                //do_loop = LessThan10.LessThan();
                //do_loop = Divisors.FindDivisors();
                // do_loop = ListIntersection.FindListIntersection();
                // do_loop = Palindrome.IsPalindrome();
                // do_loop = TestingGround.TimesTable();
                do_loop = Fibonacci.FindFibonacci();
            } while (do_loop == true);
        }
    }
}