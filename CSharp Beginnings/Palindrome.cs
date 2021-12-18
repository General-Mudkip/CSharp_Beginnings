using System;

namespace Tutorials
{
    public class Palindrome
    {
        public static bool IsPalindrome()
        {
            Console.WriteLine("Enter a word.");
            string user_input = Console.ReadLine();

            int length = user_input.Length;

            for (int i = 0; i < length; i++)
            {
                if (user_input[i] != user_input[(length - i-1)])
                {
                    Console.WriteLine("{0} is not a palindrome.", user_input);
                    return true;
                }
            }
            Console.WriteLine("{0} is a palindrome!", user_input);
            return true;
        }
    }
}