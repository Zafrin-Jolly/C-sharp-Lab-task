using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask7
{
    class NewScientificCalculator : Calculator, IBasicCalculatorInterface, IScientificCalculator
    {
        public int fact { get; set; }
        public NewScientificCalculator() { }
        public NewScientificCalculator(String name,String power):base(name,power)
        {
        
        }
        public void division(int x, int y)
        {
            int d = x / y;
            Console.WriteLine("In Scientific calculator,The division of : "+d);
            Console.WriteLine();
        }

        public void factorial(int number)
        {

            {
                
                fact = number;
               
                for (int i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }
                Console.Write("Factorial of " + number + " is: " + fact);
                Console.WriteLine();
            }
        }

        public void multiplication(int x, int y)
        {
            int m = x * y;
            Console.WriteLine("In Scientific calculator,The multiplication: " +m);
            Console.WriteLine();
        }

        public void sub(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine("In Scientific calculator,The subtraction: "+sub);
            Console.WriteLine();
        }

        public void sum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("In Scientific calculator,The summation : "+sum); 
            Console.WriteLine();
        }

        public void XtoY(int x, int y)
        {
            int basetothepower = x ^ y;
            Console.WriteLine("In Scientific calculator,The base^power: "+basetothepower);
            Console.WriteLine();
        }
    }
}
