using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask7
{
    class NewBasicCalculator : Calculator, IBasicCalculatorInterface
    {
        public NewBasicCalculator() { }
        public NewBasicCalculator(string name,string power):base( name, power)
        {

        }
        public void division(int x, int y)
        {
            int d = x / y;
            Console.WriteLine("In Basic calculator,The division : " + d);
            Console.WriteLine();
        }

        public void multiplication(int x, int y)
        {
            int m = x * y;
            Console.WriteLine("In Basic calculator,The multiplication: " + m);
            Console.WriteLine();
        }

        public void sub(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine("In Basic calculator,The subtraction: " + sub);
            Console.WriteLine();
        }

        public void sum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("In Basic calculator,The summation : " + sum);
            Console.WriteLine();
        }

    }
}
