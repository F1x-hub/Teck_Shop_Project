using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp51
{
    internal class XmlFile
    {
        AddProduct product = new AddProduct();

        

        public void ComputerAddXml(List<ElectronicDevice> electronicDevices)
        {
            product.AddComputer(electronicDevices) ;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\computers.xml";
            XElement computersElement = new XElement("Computers");

            foreach (ElectronicDevice device in electronicDevices)
            {
                if (device is Computer computer)
                {
                    XElement computerElement = new XElement("Computer", computer);

                    computersElement.Add(computerElement);
                }
            }

            XDocument xDocument = new XDocument(computersElement);
            xDocument.Save(path);
            Console.WriteLine("XML file saved successfully.");
        }
    }
}
