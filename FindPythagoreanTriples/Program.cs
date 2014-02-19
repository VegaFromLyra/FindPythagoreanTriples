using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Pythagorean triplet is a set {a, b, c} such that a*a = b*b + c*c
// Time complexity - O(n * n)
namespace FindPythagoreanTriples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 3, 4, 5, 6, 7, 8, 10, 11};

            // Square each element
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i];
            }

            Array.Sort(arr);

            int left = 0;
            int right = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                left = 0;
                right = i - 1;

                while (right >= 0 && (left < right))
                {
                    if (arr[i] == arr[left] + arr[right])
                    {
                        Console.WriteLine("{0} {1} {2}", Math.Sqrt(arr[left]), 
                                                         Math.Sqrt(arr[right]),
                                                         Math.Sqrt(arr[i]));
                        left++;
                        right--;
                    }
                    else if (arr[i] < (arr[left] + arr[right]))
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }
        }
    }
}
