using ConsoleApp51.Model.Persons;
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
        void AddAllInOneComputer(List<ElectronicDevice> devices);
        void AddCase(List<ElectronicDevice> devices);
        void AddCooler(List<ElectronicDevice> devices);
        void AddCPU(List<ElectronicDevice> devices);
        void AddGPU(List<ElectronicDevice> devices);
        void AddHardDrive(List<ElectronicDevice> devices);
        void AddMotherboard(List<ElectronicDevice> devices);
        void AddPowerSupply(List<ElectronicDevice> devices);
        void AddRAM(List<ElectronicDevice> devices);
        void AddPhone(List<ElectronicDevice> devices);
        void AddConsoles(List<ElectronicDevice> devices);
        void AddLaptop(List<ElectronicDevice> devices);
        void AddTablet(List<ElectronicDevice> devices);

        void AddPerson(List<Person> people);
    }
}
