using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class Laptop : ElectronicDevice
    {
        public string Processor { get; set; }
        public int RAM { get; set; }
        public string GPU { get; set; }
        public int Weight { get; set; }
        public string Resolution { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Laptop: {Brand} {Model}, Processor: {Processor}, RAM: {RAM}GB, GPU: {GPU}, Resolution: {Resolution}, Weight: {Weight}kg Price: ${Price}");
        }
    }
}
