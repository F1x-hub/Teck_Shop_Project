using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class Laptop : ElectronicDevice
    {
        public string Type { get; set; }
        public int ScreenSize { get; set; }
        public string ScreenType { get; set; }
        public int ScreenResolutionX { get; set; }
        public int ScreenResolutionY { get; set; }
        public string Touch { get; set; }
        public string MatrixType { get; set; }
        public int RefreshRate { get; set; }
        public string Processor { get; set; }
        public string ProcessorModel { get; set; }
        public string ProcessorSpeed { get; set; }
        public int NumberOfCores { get; set; }
        public int NumberOfThreads { get; set; }
        public int RAM { get; set; }
        public string RAMType { get; set; }
        public string HardDriveType { get; set; }
        public int HardDriveCapacity { get; set; }
        public string VideoAdapterType { get; set; }
        public string GPUModel { get; set; }
        public int VideoMemory { get; set; }
        public string Interface { get; set; }
        public string OperatingSystem { get; set; }
        public string OpticalDrive { get; set; }
        public string Connectivity { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public override string DisplayInfo()
        {
            return            $" Laptop: {Brand} {Model}\n" +
                              $" Display\n\n" +
                              $" Type: {Type}\n" +
                              $" Screen Size: {ScreenSize}\"\n" +
                              $" Screen type: {ScreenType}\n" +
                              $" Resolution: {ScreenResolutionX} x {ScreenResolutionY}\n" +
                              $" Touch: {Touch}\n" +
                              $" Matrix type: {MatrixType}\n" +
                              $" Refresh Rate: {RefreshRate} Hz\n" +
                              $" Processor\n\n" +
                              $" Type of Processor/Chipset: {Processor}\n" +
                              $" Model Of Processor: {ProcessorModel}\n" +
                              $" Processor Speed: {ProcessorSpeed}\n" +
                              $" Number Of Cores / Thread: {NumberOfCores} : {NumberOfThreads}\n" +
                              $" Memory\n\n" +
                              $" RAM: {RAM} GB\n" +
                              $" Type Of RAM Memory: {RAMType}\n" +
                              $" Hard Drive/SSD\n\n" +
                              $" Hard Drive/SSD: {HardDriveType}\n" +
                              $" SSD Hard Disk Capacity: {HardDriveCapacity} GB\n" +
                              $" Video Adapter\n\n" +
                              $" Type Of Video Adapter: {VideoAdapterType}\n" +
                              $" GPU Model: {GPUModel}\n" +
                              $" Video Card Memory: {VideoMemory} GB\n" +
                              $" Interface\n\n" +
                              $" Interface: {Interface}\n" +
                              $" Operating System\n\n" +
                              $" Operating System: {OperatingSystem}\n" +
                              $" Optical Drive\n\n" +
                              $" Optical Drive: {OpticalDrive}\n" +
                              $" Additional features\n\n" +
                              $" Connectivity: {Connectivity}\n" +
                              $" Physical settings\n\n" +
                              $" Weight: {Weight}\n" +
                              $" Color: {Color}\n";
        }                     
     }
}
