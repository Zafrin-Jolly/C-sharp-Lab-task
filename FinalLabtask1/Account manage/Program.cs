using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_manage
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Saving("Zafrin", "12344", 5000);
            a1.ShowInfo();
            a1.Deposit(23238);
            a1.Withdraw(12190);
            a1.ShowInfo();
            Console.WriteLine();
            /* int a = Int32.Parse(DateTime.Now.Year.ToString());
             Console.WriteLine(DateTime.Now.Year.ToString());*/
            Account a2 = new Fixed("Zafrin", "12344", 5420, 4, 2016);
            a2.ShowInfo();
            a2.Deposit(3000);
            a2.Withdraw(2320);
            a2.ShowInfo();

        }
    }
}
