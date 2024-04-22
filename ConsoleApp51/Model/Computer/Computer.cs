using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class Computer : ElectronicDevice
    {
        public string ProcessorManufacturer { get; set; }
        public string TypeOfProcessor{ get; set; }
        public int ModelOfProcessor { get; set; }
        public int Cores { get; set; }
        public int Thread { get; set; }
        public string CPUFrequency { get; set; }
        public int RAM { get; set; }
        public string TypeOfRAMMemory { get; set; }
        public int RAMMemorySpeed { get; set; }
        public string HardDriveSSD { get; set; }
        public int SSDInterface { get; set; }
        public string TypeOfVideoAdapter { get; set; }
        public string GraphicController { get; set; }
        public string Interface { get; set; }
        public string OperatingSystem { get; set; }
        public string Connectivity { get; set; }
        public string Dimensions { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string IncludedAccessories { get; set; }

        public override string DisplayInfo()
        {
            return            $" Computer: {Brand} {Model}\n" +
                              $" Processor\n\n" +
                              $" Processor Manufacturer: {ProcessorManufacturer}\n" +
                              $" Type of Processor: {TypeOfProcessor}\n" +
                              $" Model Of Processor: {ModelOfProcessor}\n" +
                              $" Number Of Cores / Thread : {Cores}:{Thread}\n" +
                              $" CPU frequency: {CPUFrequency}\n" +
                              $" Memory\n\n" +
                              $" RAM: {RAM}GB\n" +
                              $" Type Of RAM Memory: {TypeOfRAMMemory}\n" +
                              $" RAM Memory Speed: {RAMMemorySpeed}MHz\n" +
                              $" Hard Drive/SSD\n\n" +
                              $" Hard Drive/SSD: {HardDriveSSD}\n" +
                              $" SSD Interface: {SSDInterface}GB\n" +
                              $" Video Adapter\n\n" +
                              $" Type Of Video Adapter : {TypeOfVideoAdapter}\n" +
                              $" Graphic Controller: {GraphicController}\n" +
                              $" Interface\n\n" +
                              $" Interface: {Interface}\n" +
                              $" Operating System\n\n" +
                              $" Operating System: {OperatingSystem}\n" +
                              $" Additional features\n\n" +
                              $" Connectivity: {Connectivity}\n" +
                              $" Physical settings\n\n" +
                              $" Dimensions: {Dimensions}mm\n" +
                              $" Weight: {Weight}kg\n" +
                              $" Color: {Color}\n" +
                              $" Additional information\n\n" +
                              $" Included Accessories: {IncludedAccessories}\n" +
                              $" \n Price: {Price}\n";
        }
       
    }
}
