using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51.Device.ComputerParts
{
    internal class Cooler : ElectronicDevice
    {
        public string Destination { get; set; }
        public string SocketCompatibility { get; set; }
        public int NumberOfFan { get; set; }
        public int RotationalSpeed { get; set; }
        public string FanDimensions { get; set; }
        public string FanNoiseLevel { get; set; }
        public string Lighting { get; set; }

        public override string DisplayInfo()
        {
            return            $" Detailed Description\n\n" +
                              $" Destination: {Destination}\n" +
                              $" Socket Compatibility: {SocketCompatibility}\n" +
                              $" Number Of Fan: {NumberOfFan}\n" +
                              $" Rotational Speed: {RotationalSpeed} RPM\n" +
                              $" Fan Dimensions: {FanDimensions}\n" +
                              $" Fan Noise Level: {FanNoiseLevel}\n" +
                              $" Lighting: {Lighting}\n" +
                              $" \n Price: {Price}\n";
        }
    }
}
