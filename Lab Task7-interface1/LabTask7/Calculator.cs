using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask7
{
   abstract class Calculator
    {
       
        public String name { get; set; }
        public String power{ get; set; }

        public Calculator() { }
        public Calculator(String name,String power)
        {
            this.name=name;
            this.power=power;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name of the calculator: "+name);
            Console.WriteLine("Power: "+power);
            Console.WriteLine("------------------------------");
        }
    }
}
