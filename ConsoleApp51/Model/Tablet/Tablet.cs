using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51.Device.Tablet
{
    internal class Tablet : ElectronicDevice
    {
        public double ScreenSize { get; set; }
        public int ScreenResolutionX { get; set; }
        public int ScreenResolutionY { get; set; }
        public int PPI { get; set; }
        public string PanelType { get; set; }
        public string SIMType { get; set; }
        public string Processor { get; set; }
        public string ProcessorSpeed { get; set; }
        public int RAM { get; set; }
        public int InternalMemory { get; set; }
        public string MemoryCardSupport { get; set; }
        public int Camera { get; set; }
        public int FrontalCamera { get; set; }
        public string Interface { get; set; }
        public string TypeOfBattery { get; set; }
        public string OperatingSystem { get; set; }
        public string Sensors { get; set; }
        public string Communication { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
        public override string DisplayInfo()
        {
            return            $" Tablet: {Brand} {Model}" +
                              $" Display\n\n" +
                              $" Screen Size: {ScreenSize}\n" +
                              $" Screen Resolution: {ScreenResolutionX}x{ScreenResolutionY}\n" +
                              $" PPI: {PPI}\n" +
                              $" Screen/Panel Type: {PanelType}\n" +
                              $" SIM Type: {SIMType}\n" +
                              $" Processor\n\n" +
                              $" Processor: {Processor}\n" +
                              $" Processor Speed: {ProcessorSpeed}\n" +
                              $" Memory\n\n" +
                              $" RAM: {RAM}GB\n" +
                              $" Internal Memory: {InternalMemory}GB\n" +
                              $" Memory Card Support: {MemoryCardSupport}\n" +
                              $" Camera\n\n" +
                              $" Camera: {Camera}MP\n" +
                              $" Frontal Camera: {FrontalCamera}MP\n" +
                              $" Interface\n\n" +
                              $" Interface: {Interface}\n" +
                              $" Power\n\n" +
                              $" Type Of Battery: {TypeOfBattery}\n" +
                              $" Operating System\n\n" +
                              $" Operating System: {OperatingSystem}\n" +
                              $" Additional features\n\n" +
                              $" Sensors: {Sensors}\n" +
                              $" Communication: {Communication}\n" +
                              $" Physical settings\n\n" +
                              $" Size: {Size}\n" +
                              $" Weight: {Weight}\n" +
                              $" Color: {Color}\n";
        }
    }
}
