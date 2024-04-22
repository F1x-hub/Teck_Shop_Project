using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51.Device.ComputerParts
{
    internal class CPU : ElectronicDevice 
    {
        public string Processor { get; set; }
        public int ModelName { get; set; }
        public double ProcessorSpeed { get; set; }
        public double MaxProcessorSpeed { get; set; }
        public int Cores { get; set; }
        public int Thread { get; set; }
        public int Cache { get; set; }
        public string MemoryTypes { get; set; }
        public int MaxMemorySize { get; set; }
        public string IntegratedGraphicCard { get; set; }
        public string GraphicCardModel { get; set; }
        public int Socket { get; set; }
        public double PCIExpressVersion { get; set; }
        public int TDP { get; set; }

        public override string DisplayInfo()
        {
            return            $" Detailed Description\n\n" +
                              $" Processor: {Processor}\n" +
                              $" Model name: {ModelName}\n" +
                              $" Processor Speed: {ProcessorSpeed}GHz\n" +
                              $" Max Processor Speed: {MaxProcessorSpeed}GHz\n" +
                              $" Number Of Cores / Thread: {Cores}:{Thread}\n" +
                              $" Cache: {Cache}Mb\n" +
                              $" Memory Types: {MemoryTypes}\n" +
                              $" Max Memory Size: {MaxMemorySize}GB\n" +
                              $" Integrated Graphic Card: {IntegratedGraphicCard}\n" +
                              $" Graphic Card model: {GraphicCardModel}\n" +
                              $" Socket: {Socket}\n" +
                              $" PCI Express Version: {PCIExpressVersion}\n" +
                              $" TDP: {TDP}W (MAX)\n" +
                              $" \n Price: {Price}\n";
        }
    }
}
