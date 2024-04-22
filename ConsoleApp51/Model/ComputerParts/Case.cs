using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51.Device.ComputerParts
{
    internal class Case : ElectronicDevice
    {
        public string CaseType { get; set; }
        public string MotherboardFormFactor { get; set; }
        public string Cooling { get; set; }
        public string InterfaceButtons { get; set; }
        public bool LiquidCoolingCompatibility { get; set; }
        public string Dimensions { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }

        public override string DisplayInfo()
        {
            return            $" Case: {Brand} {Model}\n" +
                              $" Detailed Description\n\n" +
                              $" Case Type: {CaseType}\n" +
                              $" Motherboard Form Factor: {MotherboardFormFactor}\n" +
                              $" Cooling: {Cooling}\n" +
                              $" Interface/Buttons: {InterfaceButtons}\n" +
                              $" Liquid Cooling Compatibility: {(LiquidCoolingCompatibility ? "Yes" : "No")}\n" +
                              $" Dimensions: {Dimensions}\n" +
                              $" Weight: {Weight} kg\n" +
                              $" Color: {Color}\n" +
                              $" \n Price: {Price}\n";
        }
    }
}
