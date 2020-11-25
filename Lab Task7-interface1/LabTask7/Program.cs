using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask7
{
    class Program
    {
        static void Main(string[] args)
        {
            NewBasicCalculator c = new NewBasicCalculator("Abacus","100");
            c.ShowInfo();
            c.division(15, 3);
            c.multiplication(12, 14);
            c.sub(189, 123);
            c.sum(100, 100);

            NewScientificCalculator s = new NewScientificCalculator("Casio", " fx-115ES PLUS"); ;
            s.ShowInfo();
            s.factorial(5);
            s.XtoY(2, 8);
            s.sum(200, 200);
            s.sub(123, 123);
            s.multiplication(5, 10);
            s.division(100, 10);

        }
    }
}
