using ConsoleApp51.Controler;
using ConsoleApp51.Device.Computer;
using ConsoleApp51.Model.Persons;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp51
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            List<ElectronicDevice> electronicDevices = new List<ElectronicDevice>();
            List<Person> people = new List<Person>();
            LoadXmlFile loadXmlFile = new LoadXmlFile();
            StoreMenu storeMenu = new StoreMenu();
            AddXmlFile addXmlFile = new AddXmlFile();
            addXmlFile.CreateFolders();
            electronicDevices.AddRange(loadXmlFile.ComputerLoadXml());
            electronicDevices.AddRange(loadXmlFile.AllInOneComputerLoadXml());
            electronicDevices.AddRange(loadXmlFile.ConsolesLoadXml());
            electronicDevices.AddRange(loadXmlFile.CaseLoadXml());
            electronicDevices.AddRange(loadXmlFile.CoolerLoadXml());
            electronicDevices.AddRange(loadXmlFile.CPULoadXml());
            electronicDevices.AddRange(loadXmlFile.GPULoadXml());
            electronicDevices.AddRange(loadXmlFile.HardDriveLoadXml());
            electronicDevices.AddRange(loadXmlFile.MotherboardLoadXml());
            electronicDevices.AddRange(loadXmlFile.PowerSupplyLoadXml());
            electronicDevices.AddRange(loadXmlFile.RAMLoadXml());
            electronicDevices.AddRange(loadXmlFile.LaptopLoadXml());
            electronicDevices.AddRange(loadXmlFile.PhoneLoadXml());
            electronicDevices.AddRange(loadXmlFile.TabletLoadXml());
            
            storeMenu.StoreMenus(people, electronicDevices);
            
            

            
        }
        


    }
}
