using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtask02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.  int i;
             Console.WriteLine("Enter the value of n");
             int n = int.Parse(Console.ReadLine());
             Console.WriteLine("The even values from 1 to "+ n + "are");
             for (i = 2; i <= n; i += 2)
             {
                 Console.WriteLine(i);
             } */


            /* 2. for (int i = 0; i < 4; i += 1)
             {
                 for (int j = 0; j < 6; j += 1)
                 {
                     if (i%2== 0)
                     {
                         if (j % 2 == 0)
                             Console.Write("X");
                         else
                             Console.Write("0");

                     }
                     else
                     {
                         if (j % 2 == 0)
                             Console.Write("0");
                         else
                             Console.Write("X");

                     }
                 }
                 Console.WriteLine();
             }
            */

            /*3. for(int i = 1; i <=5; i += 1)
            {
                for (int j = i; j<i+5; j+= 1)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            } */

            /*4. int  i, oddS = 0, evenS = 0;
            Console.WriteLine("Enter the value of n");
            int n = int.Parse(Console.ReadLine());
            for(i=1;1<=n;i++)
            {
                if(i%2 ==0)

                    evenS = evenS + i;
        else
                        oddS = oddS + i;
                }
            Console.WriteLine("Sum of even numbers = " + evenS);
             Console.WriteLine("Sum of odd numbers = " + oddS);
            */

            /* int n;
             long factorial = 1;

             Console.WriteLine("Enter a positive integer: ");
              n = int.Parse(Console.ReadLine());

             for (int i = 1; i <= n; ++i)
             {
                 factorial *= i;
             }

             Console.WriteLine("Factorial of " + n + " = " + factorial); */
           /* int i, j, r;
            Console.WriteLine("Enter the value of rows");
            r = int.Parse(Console.ReadLine());

            for (i = r; i >= 1; --i)
            {
                for (j = 1; j <= i; ++j)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            } */



        }
    }
}
