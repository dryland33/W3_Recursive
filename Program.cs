using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3_Recursion
{
    class Program
    {
        static void Main(string[] args) {
            //recursiveCount();
            //backCount(100);
            Console.WriteLine(sumNums(4, 0));
        }

        // Write a program in C# Sharp to print numbers from n to 1 using recursion.
        static void recursiveCount(int i = 1) {
            Console.WriteLine(i);
            if (i < 10) {
                recursiveCount(++i);
            }
        }

        //  Write a program in C# Sharp to print numbers from n to 1 using recursion.
        static void backCount(int i) {
            Console.WriteLine(i);
            if (i > 1) {
                backCount(--i);
            }
        }

        //Write a program in C# Sharp to find the sum of first n natural numbers using recursion.
        static int sumNums(int i, int sum) {
           
            if (i == 0) {
                return sum;
            }
            sum += i;
            return sumNums(--i, sum);
        }

    }
}
