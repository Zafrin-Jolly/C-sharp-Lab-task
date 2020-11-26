using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_interface3
{
    abstract class Device
    {
        public String deviceName { get; set; }
        public String  model { get; set; }
        public int volume { get; set; }

        public Device() { }
        public Device(String deviceName,String model )
        {
            this.model = model;
            this.deviceName = deviceName;
           
        }
        public void showInfo()
        {
            Console.WriteLine("The name of the device :" +deviceName);
            Console.WriteLine("The model name is: "+model);
           
        }
    }
}
