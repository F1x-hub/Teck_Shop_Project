using Aardvark.Base.Native;
using ConsoleApp51.Device.Computer;
using ConsoleApp51.Device.ComputerParts;
using ConsoleApp51.Device.Tablet;
using ConsoleApp51.Model.Persons;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ConsoleApp51.Controler
{
    internal class StoreMenu
    {
        List<ElectronicCategory> electronicCategories = new List<ElectronicCategory>()
        {
                new ElectronicCategory(){ElectronicId = 1, CategoryName = "Computer"},
                new ElectronicCategory(){ElectronicId = 2, CategoryName = "ComputerParts"},
                new ElectronicCategory(){ElectronicId = 3, CategoryName = "Tablet"},
        };
        List<DeviceCategory> deviceCategories = new List<DeviceCategory>()
        {
                new DeviceCategory(){ ElectronicId = 1, DeviceId = 1, CategoryDeviceName = "AllInOneComputer"},
                new DeviceCategory(){ ElectronicId = 1, DeviceId = 2, CategoryDeviceName = "Computer"},
                new DeviceCategory(){ ElectronicId = 1, DeviceId = 3, CategoryDeviceName = "Consoles"},

                new DeviceCategory(){ ElectronicId = 2, DeviceId = 1, CategoryDeviceName = "Case"},
                new DeviceCategory(){ ElectronicId = 2, DeviceId = 2, CategoryDeviceName = "Cooler"},
                new DeviceCategory(){ ElectronicId = 2, DeviceId = 3, CategoryDeviceName = "CPU"},
                new DeviceCategory(){ ElectronicId = 2, DeviceId = 4, CategoryDeviceName = "GPU"},
                new DeviceCategory(){ ElectronicId = 2, DeviceId = 5, CategoryDeviceName = "HardDrive"},
                new DeviceCategory(){ ElectronicId = 2, DeviceId = 6, CategoryDeviceName = "Motherboard"},
                new DeviceCategory(){ ElectronicId = 2, DeviceId = 7, CategoryDeviceName = "PowerSupply"},
                new DeviceCategory(){ ElectronicId = 2, DeviceId = 8, CategoryDeviceName = "RAM"},

                new DeviceCategory(){ ElectronicId = 3, DeviceId = 1, CategoryDeviceName = "Laptop"},
                new DeviceCategory(){ ElectronicId = 3, DeviceId = 2, CategoryDeviceName = "Phone"},
                new DeviceCategory(){ ElectronicId = 3, DeviceId = 3, CategoryDeviceName = "Tablet"}
        };

        LoadXmlFile loadXmlFile = new LoadXmlFile();
        AddXmlFile xmlFile = new AddXmlFile();
        
        Model.Persons.Authorization authorization = new Model.Persons.Authorization();
        
        public void StoreMenus(List<Person> people, List<ElectronicDevice> electronicDevices)
        {
            xmlFile.CreateFolders();

            object person = authorization.Authorizations(people);

            if (person != null)
            {
                if (person is User user)
                {
                    string controler = "0";
                    while (controler != "4")
                    {
                        
                        Console.WriteLine("Store");
                        Console.WriteLine("1. Buy Product\n2. Account Setting\n3. Buyng Product\n4. Exit");
                        controler = Console.ReadLine();
                        if (controler == "1")
                        {
                            BuyngProduct(electronicDevices, user);
                        }
                        if (controler == "2")
                        {

                        }
                        if (controler == "3")
                        {
                            string path = authorization.GetUserFolderPath(user.UserName);
                            ReadTextFile(path);
                        }
                    }
                    
                }
                if (person is Admin)
                {
                    AdminCRUDMenu(electronicDevices);
                }
            }
        }
        public void AdminCRUDMenu(List<ElectronicDevice> electronicDevices)
        {
            string controler = "0";
            while (controler != "5")
            {
                Console.WriteLine("Admin Menu\n");
                Console.WriteLine("1. Create\n2. Read\n3. Update\n4. Delete\n5. Exit");

                controler = Console.ReadLine();

                if (controler == "1")
                {
                    CreateDevice(electronicDevices);
                }
                if (controler == "2")
                {
                    ReadDevice(electronicDevices);
                }

            }
        }
        public void ReadDevice(List<ElectronicDevice> electronicDevices)
        {
            var groupedCategories = GroupJoinCategories(electronicCategories, deviceCategories);


            Console.WriteLine("Available Categories:");
            foreach (var category in groupedCategories)
            {
                Console.WriteLine($"- {category.ElectronicCategory.CategoryName} (ID: {category.ElectronicCategory.ElectronicId})");
            }


            Console.WriteLine("Select a category by entering its ElectronicId:");
            int selectedCategoryId = int.Parse(Console.ReadLine());





            Console.WriteLine("Devices in the selected category:");
            if (selectedCategoryId == 1)
            {
                Console.WriteLine("- AllInOneComputer (1)");
                Console.WriteLine("- Computer (2)");
                Console.WriteLine("- Consoles (3)");
            }
            if (selectedCategoryId == 2)
            {
                Console.WriteLine("- Case (1)");
                Console.WriteLine("- Cooler (2)");
                Console.WriteLine("- CPU (3)");
                Console.WriteLine("- GPU (4)");
                Console.WriteLine("- HardDrive (5)");
                Console.WriteLine("- Motherboard (6)");
                Console.WriteLine("- PowerSupply (7)");
                Console.WriteLine("- RAM (8)");

            }
            if (selectedCategoryId == 3)
            {
                Console.WriteLine("- Laptop (1)");
                Console.WriteLine("- Phone (2)");
                Console.WriteLine("- Tablet (3)");
            }



            Console.WriteLine("Select a device by entering its DeviceId:");
            int selectedDeviceId = int.Parse(Console.ReadLine());


            List<ElectronicDevice> newElectronicDevices = GetDevice(selectedCategoryId, selectedDeviceId, electronicDevices);

            if (newElectronicDevices.Count > 0)
            {
                foreach (var device in newElectronicDevices)
                {
                    Console.WriteLine($"Device: {device.Brand} {device.Model} {device.Price}");
                }
                Console.WriteLine("You Want See Detail?(Y/N)");
                string choise = Console.ReadLine();
                if (choise == "Y" || choise == "y")
                {
                    Console.Write("Choise Product By Model: ");
                    string model = Console.ReadLine();

                    var device = newElectronicDevices.FirstOrDefault(n => n.Model.ToLower() == model.ToLower());
                    if (device != null)
                    {
                        Console.WriteLine(device.DisplayInfo());
                    }
                }
            }
        }
        public void CreateDevice(List<ElectronicDevice> electronicDevices)
        {
            var groupedCategories = GroupJoinCategories(electronicCategories, deviceCategories);


            Console.WriteLine("Available Categories:");
            foreach (var category in groupedCategories)
            {
                Console.WriteLine($"- {category.ElectronicCategory.CategoryName} (ID: {category.ElectronicCategory.ElectronicId})");
            }


            Console.WriteLine("Select a category by entering its ElectronicId:");
            int selectedCategoryId = int.Parse(Console.ReadLine());





            Console.WriteLine("Devices in the selected category:");
            if (selectedCategoryId == 1)
            {
                Console.WriteLine("- AllInOneComputer (1)");
                Console.WriteLine("- Computer (2)");
                Console.WriteLine("- Consoles (3)");
            }
            if (selectedCategoryId == 2)
            {
                Console.WriteLine("- Case (1)");
                Console.WriteLine("- Cooler (2)");
                Console.WriteLine("- CPU (3)");
                Console.WriteLine("- GPU (4)");
                Console.WriteLine("- HardDrive (5)");
                Console.WriteLine("- Motherboard (6)");
                Console.WriteLine("- PowerSupply (7)");
                Console.WriteLine("- RAM (8)");

            }
            if (selectedCategoryId == 3)
            {
                Console.WriteLine("- Laptop (1)");
                Console.WriteLine("- Phone (2)");
                Console.WriteLine("- Tablet (3)");
            }



            Console.WriteLine("Select a device by entering its DeviceId:");
            int selectedDeviceId = int.Parse(Console.ReadLine());

            AddDeviceInXml(selectedCategoryId, selectedDeviceId, electronicDevices);
        }
        public void BuyngProduct(List<ElectronicDevice> electronicDevices, User user)
        {
            if (user != null)
            {
                var groupedCategories = GroupJoinCategories(electronicCategories, deviceCategories);


                Console.WriteLine("Available Categories:");
                foreach (var category in groupedCategories)
                {
                    Console.WriteLine($"- {category.ElectronicCategory.CategoryName} (ID: {category.ElectronicCategory.ElectronicId})");
                }


                Console.WriteLine("Select a category by entering its ElectronicId:");
                int selectedCategoryId = int.Parse(Console.ReadLine());





                Console.WriteLine("Devices in the selected category:");
                if (selectedCategoryId == 1)
                {
                    Console.WriteLine("- AllInOneComputer (1)");
                    Console.WriteLine("- Computer (2)");
                    Console.WriteLine("- Consoles (3)");
                }
                if (selectedCategoryId == 2)
                {
                    Console.WriteLine("- Case (1)");
                    Console.WriteLine("- Cooler (2)");
                    Console.WriteLine("- CPU (3)");
                    Console.WriteLine("- GPU (4)");
                    Console.WriteLine("- HardDrive (5)");
                    Console.WriteLine("- Motherboard (6)");
                    Console.WriteLine("- PowerSupply (7)");
                    Console.WriteLine("- RAM (8)");

                }
                if (selectedCategoryId == 3)
                {
                    Console.WriteLine("- Laptop (1)");
                    Console.WriteLine("- Phone (2)");
                    Console.WriteLine("- Tablet (3)");
                }



                Console.WriteLine("Select a device by entering its DeviceId:");
                int selectedDeviceId = int.Parse(Console.ReadLine());


                List<ElectronicDevice> newElectronicDevices = GetDevice(selectedCategoryId, selectedDeviceId, electronicDevices);

                if (newElectronicDevices.Count > 0)
                {
                    foreach (var device in newElectronicDevices)
                    {
                        Console.WriteLine($"Device: {device.Brand} {device.Model} {device.Price}");
                    }
                    Console.WriteLine("You Want Buy something?(Y/N)");
                    string choise = Console.ReadLine();
                    if (choise == "Y" || choise == "y")
                    {
                        Console.Write("Choise Product By Model: ");
                        string model = Console.ReadLine();

                        var device = newElectronicDevices.FirstOrDefault(n => n.Model.ToLower() == model.ToLower());

                        if (device != null)
                        {
                            Console.WriteLine(device.DisplayInfo());
                            Console.WriteLine($"Do Want Buy {device.Model}?(Y/N)");

                            string choise2 = Console.ReadLine();
                            if (choise2 == "Y" || choise2 == "y")
                            {
                                string path = authorization.GetUserFolderPath(user.UserName);
                                string fileName = $"{device.Model}-{user.FirstName}.txt";



                                string filePath = Path.Combine(path, fileName);


                                File.WriteAllText(filePath, device.DisplayInfo());
                            }
                            
                            
                        }

                    }
                }
                else
                {
                    Console.WriteLine($" Device Not Found!");
                }
            }
            
            
            
        }
        public string ReadTextFile(string directoryPath)
        {
            try
            {
                
                if (Directory.Exists(directoryPath))
                {
                    
                    string[] files = Directory.GetFiles(directoryPath, "*.txt");

                    if (files.Length == 0)
                    {
                        return "No text files found in the directory.";
                        
                    }

                    foreach (string file in files)
                    {
                        
                        string content = File.ReadAllText(file);

                        
                        Console.WriteLine($"Content of {Path.GetFileName(file)}:");
                        Console.WriteLine(content);
                        Console.WriteLine();
                        return content;
                    }
                    return "";
                }
                else
                {
                    return "Directory not found.";
                }
            }
            catch (Exception ex)
            {
                
                return $"Error reading files: {ex.Message}";
            }
        }
        public void AddDeviceInXml(int selectedCategoryId, int selectedDeviceId, List<ElectronicDevice> electronicDevices)
        {
            if (selectedCategoryId == 1 && selectedDeviceId == 1)
            {
                xmlFile.AllInOneComputerAddXml(electronicDevices);
            }
            if (selectedCategoryId == 1 && selectedDeviceId == 2)
            {
                xmlFile.ComputerAddXml(electronicDevices);
            }
            if (selectedCategoryId == 1 && selectedDeviceId == 3)
            {
                xmlFile.ConsolesAddXml(electronicDevices);
            }
            if (selectedCategoryId == 2 && selectedDeviceId == 1)
            {
                xmlFile.CaseAddXml(electronicDevices);
            }
            if (selectedCategoryId == 2 && selectedDeviceId == 2)
            {
                xmlFile.CoolerAddXml(electronicDevices);
            }
            if (selectedCategoryId == 2 && selectedDeviceId == 3)
            {
                xmlFile.CPUAddXml(electronicDevices);
            }
            if (selectedCategoryId == 2 && selectedDeviceId == 4)
            {
                xmlFile.GPUAddXml(electronicDevices);
            }
            if (selectedCategoryId == 2 && selectedDeviceId == 5)
            {
                xmlFile.HardDriveAddXml(electronicDevices);
            }
            if (selectedCategoryId == 2 && selectedDeviceId == 6)
            {
                xmlFile.MotherboardAddXml(electronicDevices);
            }
            if (selectedCategoryId == 2 && selectedDeviceId == 7)
            {
                xmlFile.PowerSupplyAddXml(electronicDevices);
            }
            if (selectedCategoryId == 2 && selectedDeviceId == 8)
            {
                xmlFile.RAMAddXml(electronicDevices);
            }
            if (selectedCategoryId == 3 && selectedDeviceId == 1)
            {
                xmlFile.LaptopAddXml(electronicDevices);
            }
            if (selectedCategoryId == 3 && selectedDeviceId == 2)
            {
                xmlFile.PhoneAddXml(electronicDevices);
            }
            if (selectedCategoryId == 3 && selectedDeviceId == 3)
            {
                xmlFile.TabletAddXml(electronicDevices);
            }
        }
        public List<ElectronicDevice> GetDevice(int selectedCategoryId, int selectedDeviceId, List<ElectronicDevice> electronicDevices)
        {
            List<ElectronicDevice> resultDevices = new List<ElectronicDevice>();

            if (selectedCategoryId == 1 && selectedDeviceId == 1)
            {
                foreach (var device in electronicDevices)
                {
                    if (device is AllInOneComputer allInOneComputer)
                    {
                        resultDevices.Add(allInOneComputer);
                        
                    }
                }
            }
            if (selectedCategoryId == 1 && selectedDeviceId == 2)
            {
                foreach (var device in electronicDevices)
                {
                    if (device is Computer computer)
                    {
                        resultDevices.Add(computer);
                        
                    }
                }
            }
            if (selectedCategoryId == 1 && selectedDeviceId == 3)
            {
                foreach (var device in electronicDevices)
                {
                    if (device is Consoles console)
                    {
                        resultDevices.Add(console);
                        
                    }
                }
            }
            if (selectedCategoryId == 2 && selectedDeviceId == 1)
            {
                foreach (var device in electronicDevices)
                {
                    if (device is Case cases)
                    {
                        resultDevices.Add(cases);

                    }
                }
            }
            if (selectedCategoryId == 2 && selectedDeviceId == 2)
            {
                foreach (var device in electronicDevices)
                {
                    if (device is Cooler cooler)
                    {
                        resultDevices.Add(cooler);

                    }
                }
            }
            if (selectedCategoryId == 2 && selectedDeviceId == 3)
            {
                foreach (var device in electronicDevices)
                {
                    if (device is CPU cpu)
                    {
                        resultDevices.Add(cpu);

                    }
                }
            }
            if (selectedCategoryId == 2 && selectedDeviceId == 4)
            {
                foreach (var device in electronicDevices)
                {
                    if (device is GPU gpu)
                    {
                        resultDevices.Add(gpu);

                    }
                }
            }
            if (selectedCategoryId == 2 && selectedDeviceId == 5)
            {
                foreach (var device in electronicDevices)
                {
                    if (device is HardDrive hardDrive)
                    {
                        resultDevices.Add(hardDrive);

                    }
                }
            }
            if (selectedCategoryId == 2 && selectedDeviceId == 6)
            {
                foreach (var device in electronicDevices)
                {
                    if (device is Motherboard motherboard)
                    {
                        resultDevices.Add(motherboard);

                    }
                }
            }
            if (selectedCategoryId == 2 && selectedDeviceId == 7)
            {
                foreach (var device in electronicDevices)
                {
                    if (device is PowerSupply powerSupply)
                    {
                        resultDevices.Add(powerSupply);

                    }
                }
            }
            if (selectedCategoryId == 2 && selectedDeviceId == 8)
            {
                foreach (var device in electronicDevices)
                {
                    if (device is RAM ram)
                    {
                        resultDevices.Add(ram);

                    }
                }
            }
            if (selectedCategoryId == 3 && selectedDeviceId == 1)
            {
                foreach (var device in electronicDevices)
                {
                    if (device is Laptop laptop)
                    {
                        resultDevices.Add(laptop);

                    }
                }
            }
            if (selectedCategoryId == 3 && selectedDeviceId == 2)
            {
                foreach (var device in electronicDevices)
                {
                    if (device is Phone phone)
                    {
                        resultDevices.Add(phone);

                    }
                }
            }
            if (selectedCategoryId == 3 && selectedDeviceId == 3)
            {
                foreach (var device in electronicDevices)
                {
                    if (device is Tablet tablet)
                    {
                        resultDevices.Add(tablet);

                    }
                }
            }
            return resultDevices;
        }
        static IEnumerable<(ElectronicCategory ElectronicCategory, IEnumerable<DeviceCategory> Devices)> GroupJoinCategories(List<ElectronicCategory> electronicCategories, List<DeviceCategory> deviceCategories)
        {
            var groupedCategories = from electronicCategory in electronicCategories
                                    join deviceCategory in deviceCategories
                                    on electronicCategory.ElectronicId equals deviceCategory.ElectronicId into grouped
                                    select (electronicCategory, grouped);

            return groupedCategories;
        }
    }
}
