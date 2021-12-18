using System;

namespace Tutorials
{
    public class Fibonacci
    {
        public static bool FindFibonacci()
        {
            int n = 5;

            int[] sequence = new int[n];
            sequence.SetValue(1,1);
            Console.WriteLine(String.Join(' ', sequence));
            
            for (int i = 2; i < n; i++)
            {
                int p1 = i - 1;
                int p2 = i - 2;
                
                Console.WriteLine(p2);

                int sum = sequence[p1] + sequence[p2];
                
                sequence.SetValue(sum, i);
            }

            String.Join(" ", sequence);
            
            return false;
        }
    }
}