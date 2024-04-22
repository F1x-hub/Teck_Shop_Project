using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51.Device.ComputerParts
{
    internal class PowerSupply : ElectronicDevice
    {
        public string FormFactor { get; set; }
        public int Watts { get; set; }
        public string InputVoltage { get; set; }
        public string InputFrequencyRange { get; set; }
        public string PowerConnectorsCPU { get; set; }
        public string PFC { get; set; }

        public override string DisplayInfo()
        {
            return            $" Detailed Description\n\n" +
                              $" Form Factor: {FormFactor}\n" +
                              $" Watts: {Watts}\n" +
                              $" Input Voltage: {InputVoltage}\n" +
                              $" Input Frequency Range: {InputFrequencyRange}\n" +
                              $" Power Connectors (CPU): {PowerConnectorsCPU}\n" +
                              $" PFC: {PFC}\n";
        }
    }
}
