using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal abstract class ElectronicDevice
    {
        public int DeviceId { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }

        public abstract void DisplayInfo();
    }
}
