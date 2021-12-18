using System;
using System.Linq;

namespace Tutorials
{
    public class ListIntersection
    {
        public static bool FindListIntersection()
        {
            int[] array1 = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] array2 = new[] {5, 7, 2, 5, 6};

            foreach (var num in array1)
            {
                if (array2.Contains(num))
                {
                    Console.WriteLine(num);
                }
            }

            return false;
        }
    }
}