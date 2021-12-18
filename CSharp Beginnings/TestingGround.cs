using System;

namespace Tutorials
{
    public class TestingGround
    {
        public static bool TimesTable()
        {
            int num = 5;
            string ans = ""; //return the correct value in this string
            //write your solution here
            int count = 0;

            do
            {
                count++;
                ans += (count*num).ToString();
                ans += " ";
            } while(count<num);

            Console.WriteLine(ans);
            return false;
        }
    }
}