using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51.Device.ComputerParts
{
    internal class GPU : ElectronicDevice
    {
        public string GraphicEngine { get; set; }
        public string GraphicEngineModel { get; set; }
        public double GPUClock { get; set; }
        public double BoostClock { get; set; }
        public string MemoryType { get; set; }
        public int Memory { get; set; }
        public int MemoryInterfaceWidth { get; set; }
        public string CoolingSystem { get; set; }
        public string Interface { get; set; }
        public string VideoCardInterface { get; set; }
        public string Dimensions { get; set; }

        public override string DisplayInfo()
        {
            return            $" Detailed Description\n\n" +
                              $" Graphic Engine: {GraphicEngine}\n" +
                              $" Graphic Engine Model: {GraphicEngineModel}\n" +
                              $" GPU Clock: {GPUClock} MHz\n" +
                              $" Boost Clock: {BoostClock} MHz\n" +
                              $" Memory Type: {MemoryType}\n" +
                              $" Memory: {Memory} GB\n" +
                              $" Memory Interface Width: {MemoryInterfaceWidth}-bit\n" +
                              $" Cooling System: {CoolingSystem}\n" +
                              $" Interface: {Interface}\n" +
                              $" Video Card Interface: {VideoCardInterface}\n" +
                              $" Dimensions: {Dimensions}\n" +
                              $" \n Price: {Price}\n";
        }
    }
}
