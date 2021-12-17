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
                do_loop = Divisors.FindDivisors();
            } while (do_loop == true);
        }
    }
}