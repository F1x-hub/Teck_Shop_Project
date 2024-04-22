using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51.Device.ComputerParts
{
    internal class RAM : ElectronicDevice
    {
        public string Compatibility { get; set; }
        public string FormFactor { get; set; }
        public int Volume { get; set; }
        public string MemoryType { get; set; }
        public int MemoryClock { get; set; }
        public string Radiator { get; set; }

        public override string DisplayInfo()
        {
            return            $" Detailed Description\n\n" +
                              $" Compatibility: {Compatibility}\n" +
                              $" Form Factor: {FormFactor}\n" +
                              $" Volume: {Volume} GB\n" +
                              $" Memory Type: {MemoryType}\n" +
                              $" Memory Clock: {MemoryClock} MHz\n" +
                              $" Radiator: {Radiator}\n";
        }
    }
}
