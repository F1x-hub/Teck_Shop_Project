using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class Phone : ElectronicDevice
    {
        public string OS { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Mobile Phone: {Brand} {Model}, Operating System: {OS}, Price: ${Price}");
        }
    }
}
