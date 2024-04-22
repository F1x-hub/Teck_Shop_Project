using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class Phone : ElectronicDevice
    {
        public string ScreenType { get; set; }
        public double ScreenSize { get; set; }
        public string Resolution { get; set; }
        public int UpdateFrequency { get; set; }
        public int RAMCapacity { get; set; }
        public int InternalMemoryCapacity { get; set; }
        public string MemoryCardSupport { get; set; }
        public string Chipset { get; set; }
        public string GraphicsProcessor { get; set; }
        public string Processor { get; set; }
        public string OperatingSystem { get; set; }
        public string Video { get; set; }
        public int Camera { get; set; }
        public string AdditionalFeatures { get; set; }
        public int SelfieCamera { get; set; }
        public string Type { get; set; }
        public double ItemVolume { get; set; }
        public string ItemType { get; set; }
        public string Ports { get; set; }
        public bool WiFi { get; set; }
        public bool GPS { get; set; }
        public bool NFC { get; set; }
        public bool Bluetooth { get; set; }
        public string Technology { get; set; }
        public string Sensors { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string BodyMaterial { get; set; }

        public override string DisplayInfo()
        {
            return            $" Phone: {Brand} {Model}\n" +
                              $" Screen\n\n" +
                              $" Screen Type: {ScreenType}\n" +
                              $" Screen Size: {ScreenSize} inches\n" +
                              $" Resolution: {Resolution}\n" +
                              $" Update Frequency: {UpdateFrequency} Hz\n" +
                              $" Memory\n\n" +
                              $" RAM Capacity: {RAMCapacity} GB\n" +
                              $" Internal Memory Capacity: {InternalMemoryCapacity} GB\n" +
                              $" Memory Card Support: {MemoryCardSupport}\n" +
                              $" platform\n\n" +
                              $" Chipset: {Chipset}\n" +
                              $" Graphics Processor: {GraphicsProcessor}\n" +
                              $" Processor: {Processor}\n" +
                              $" Operating System: {OperatingSystem}\n" +
                              $" Main camera\n\n" +
                              $" Video: {Video}\n" +
                              $" Camera: {Camera} MP\n" +
                              $" Additional Features: {AdditionalFeatures}\n" +
                              $" Selfie Camera: {SelfieCamera} MP\n" +
                              $" General Information\n\n" +
                              $" Type: {Type}\n" +
                              $" Item Volume: {ItemVolume} cm^3\n" +
                              $" Item Type: {ItemType}\n" +
                              $" Ports: {Ports}\n" +
                              $" Connectivity\n\n" +
                              $" Wi-Fi: {(WiFi ? "Yes" : "No")}\n" +
                              $" GPS: {(GPS ? "Yes" : "No")}\n" +
                              $" NFC: {(NFC ? "Yes" : "No")}\n" +
                              $" Bluetooth: {(Bluetooth ? "Yes" : "No")}\n" +
                              $" Technology: {Technology}\n" +
                              $" Sensors\n\n" +
                              $" Sensors: {Sensors}\n" +
                              $" Physical Attributes\n\n" +
                              $" Weight: {Weight} gr\n" +
                              $" Color: {Color}\n" +
                              $" Size: {Size}\n" +
                              $" Body Material: {BodyMaterial}\n";
        }
    
    }
}
