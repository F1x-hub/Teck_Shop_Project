using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class Consoles : ElectronicDevice
    {
        public string TypeOfChipset { get; set; }
        public int NumberOfCores { get; set; }
        public int RAM { get; set; }
        public string TypeOfRAMMemory { get; set; }
        public string GraphicController { get; set; }
        public string TypeOfMemory { get; set; }
        public string Interface { get; set; }
        public string OpticalDrive { get; set; }
        public string Connectivity { get; set; }
        public string Dimensions { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($" Console: {Brand} {Model}\n" +
                              $" Processor\n\n" +
                              $" TypeOfChipset: {TypeOfChipset}\n" +
                              $" NumberOfCores: {NumberOfCores}\n" +
                              $" Memory\n\n" +
                              $" RAM: {RAM}GB\n" +
                              $" TypeOfRAMMemory: {TypeOfRAMMemory}\n" +
                              $" Video Adapter\n\n" +
                              $" GraphicController: {GraphicController}\n" +
                              $" TypeOfMemory: {TypeOfMemory}\n" +
                              $" Interface\n\n" +
                              $" Interface: {Interface}\n" +
                              $" OpticalDrive\n\n" +
                              $" OpticalDrive: {OpticalDrive}\n" +
                              $" Additional features\n\n" +
                              $" Connectivity: {Connectivity}\n" +
                              $" Physical Settings\n\n" +
                              $" Dimensions: {Dimensions}\n" +
                              $" Weight: {Weight}kg\n" +
                              $" Color:{Color}\n" +
                              $" Price: ${Price}");
        }
    }
}
