using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51.Device.ComputerParts
{
    internal class HardDrive : ElectronicDevice
    {
        public string Type { get; set; }
        public string FormFactor { get; set; }
        public int StorageCapacity { get; set; }
        public string HardDriveType { get; set; }
        public string PCle { get; set; }
        public string Dimensions { get; set; }
        public double Weight { get; set; }

        public override string DisplayInfo()
        {
            return            $" Detailed Description\n\n" +
                              $" Type: {Type}\n" +
                              $" Form Factor: {FormFactor}\n" +
                              $" Storage Capacity: {StorageCapacity} GB\n" +
                              $" Hard Drive Type: {HardDriveType}\n" +
                              $" PCle: {PCle}\n" +
                              $" Dimensions: {Dimensions}\n" +
                              $" Weight: {Weight} kg\n" +
                              $" \n Price: {Price}\n";
        }
    }
}
