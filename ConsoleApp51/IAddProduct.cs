using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal interface IAddProduct
    {
        void AddComputer(List<ElectronicDevice> devices);
        void AddPhone(List<ElectronicDevice> devices);
        void AddConsoles(List<ElectronicDevice> devices);
        void AddLaptop(List<ElectronicDevice> devices);
        
    }
}
