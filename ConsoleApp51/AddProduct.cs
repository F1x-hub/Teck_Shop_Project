using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class AddProduct : IAddProduct
    {
        public void AddComputer(List<ElectronicDevice> devices)
        {
            devices.Add(new Computer() { });
        }

        public void AddConsoles(List<ElectronicDevice> devices)
        {
            throw new NotImplementedException();
        }

        public void AddLaptop(List<ElectronicDevice> devices)
        {
            throw new NotImplementedException();
        }

        public void AddPhone(List<ElectronicDevice> devices)
        {
            throw new NotImplementedException();
        }
    }
}
