using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp51.Device.ComputerParts
{
    internal class Motherboard : ElectronicDevice
    {
        public string ModelName { get; set; }
        public string FormFactor { get; set; }
        public int Socket { get; set; }
        public string Chipset { get; set; }
        public string CompatibilityProcessors { get; set; }
        public int MaxMemory { get; set; }
        public string MemoryType { get; set; }
        public int MaxMemoryMHz { get; set; }
        public int NumberOfMemorySlots { get; set; }
        public string MemorySlotsType { get; set; }
        public string VersionOfPCIExpress { get; set; }
        public string IncludedAccessories { get; set; }
        public string OperatingSystem { get; set; }
        public int DimensionsWidth { get; set; }
        public int DimensionsHeight { get; set; }

        public override string DisplayInfo()
        {
            return            $" Detailed Description\n\n" +
                              $" Model Name: {ModelName}\n" +
                              $" Form Factor: {FormFactor}\n" +
                              $" Socket: {Socket}\n" +
                              $" Chipset: {Chipset}\n" +
                              $" Compatibility Processors: {CompatibilityProcessors}\n" +
                              $" Max Memory: {MaxMemory}GB\n" +
                              $" Memory Type: {MemoryType}\n" +
                              $" Max Memory MHz: {MaxMemoryMHz}MHz\n" +
                              $" Number Of Memory Slots: {NumberOfMemorySlots}\n" +
                              $" Memory Slots Type: {MemorySlotsType}\n" +
                              $" Version of PCI Express: {VersionOfPCIExpress}\n" +
                              $" Included Accessories: {IncludedAccessories}\n" +
                              $" Operating System: {OperatingSystem}\n" +
                              $" Dimensions: {DimensionsWidth}x{DimensionsHeight} cm\n" +
                              $" \n Price: {Price}ლ\n";
        }
    }
}
