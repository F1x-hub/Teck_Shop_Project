using ConsoleApp51.Controler;
using ConsoleApp51.Device.Computer;
using ConsoleApp51.Device.ComputerParts;
using ConsoleApp51.Device.Tablet;
using ConsoleApp51.Model.Persons;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class AddProduct : IAddProduct
    {
        LoadXmlFile loadXmlFile = new LoadXmlFile();
        
        public void AddComputer(List<ElectronicDevice> devices)
        {
            Computer computer = new Computer();

            
            Console.WriteLine("Enter Computer Details:");
            Console.Write("Brand: ");
            computer.Brand = Console.ReadLine();

            Console.Write("Model: ");
            computer.Model = Console.ReadLine();

            Console.Write("Processor Manufacturer: ");
            computer.ProcessorManufacturer = Console.ReadLine();

            Console.Write("Type of Processor: ");
            computer.TypeOfProcessor = Console.ReadLine();

            Console.Write("Model of Processor: ");
            computer.ModelOfProcessor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of Cores: ");
            computer.Cores = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of Threads: ");
            computer.Thread = Convert.ToInt32(Console.ReadLine());

            Console.Write("CPU Frequency: ");
            computer.CPUFrequency = Console.ReadLine();

            Console.Write("RAM (in GB): ");
            computer.RAM = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type of RAM Memory: ");
            computer.TypeOfRAMMemory = Console.ReadLine();

            Console.Write("RAM Memory Speed: ");
            computer.RAMMemorySpeed = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hard Drive/SSD: ");
            computer.HardDriveSSD = Console.ReadLine();

            Console.Write("SSD Interface: ");
            computer.SSDInterface = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type of Video Adapter: ");
            computer.TypeOfVideoAdapter = Console.ReadLine();

            Console.Write("Graphic Controller: ");
            computer.GraphicController = Console.ReadLine();

            Console.Write("Interface: ");
            computer.Interface = Console.ReadLine();

            Console.Write("Operating System: ");
            computer.OperatingSystem = Console.ReadLine();

            Console.Write("Connectivity: ");
            computer.Connectivity = Console.ReadLine();

            Console.Write("Dimensions: ");
            computer.Dimensions = Console.ReadLine();

            Console.Write("Weight (in kg): ");
            computer.Weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Color: ");
            computer.Color = Console.ReadLine();

            Console.Write("Included Accessories: ");
            computer.IncludedAccessories = Console.ReadLine();

            Console.Write("Price: ");
            computer.Price = int.Parse(Console.ReadLine());

            
            devices.Add(computer);
        }

        public void AddConsoles(List<ElectronicDevice> devices)
        {
            Consoles consoles = new Consoles();

            
            Console.WriteLine("Enter Console Details:");
            Console.Write("Brand: ");
            consoles.Brand = Console.ReadLine();

            Console.Write("Model: ");
            consoles.Model = Console.ReadLine();

            Console.Write("Type of Chipset: ");
            consoles.TypeOfChipset = Console.ReadLine();

            Console.Write("Number of Cores: ");
            consoles.NumberOfCores = int.Parse(Console.ReadLine());

            Console.Write("RAM (in GB): ");
            consoles.RAM = int.Parse(Console.ReadLine());

            Console.Write("Type of RAM Memory: ");
            consoles.TypeOfRAMMemory = Console.ReadLine();

            Console.Write("Graphic Controller: ");
            consoles.GraphicController = Console.ReadLine();

            Console.Write("Type of Memory: ");
            consoles.TypeOfMemory = Console.ReadLine();

            Console.Write("Interface: ");
            consoles.Interface = Console.ReadLine();

            Console.Write("Optical Drive: ");
            consoles.OpticalDrive = Console.ReadLine();

            Console.Write("Connectivity: ");
            consoles.Connectivity = Console.ReadLine();

            Console.Write("Dimensions: ");
            consoles.Dimensions = Console.ReadLine();

            Console.Write("Weight (in kg): ");
            consoles.Weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Color: ");
            consoles.Color = Console.ReadLine();

            Console.Write("Price: $");
            consoles.Price = Convert.ToDouble(Console.ReadLine());

            
            devices.Add(consoles);
        }
        public void AddAllInOneComputer(List<ElectronicDevice> devices)
        {
            AllInOneComputer allInOneComputer = new AllInOneComputer();

            
            Console.WriteLine("Enter All-In-One Computer Details:");
            Console.Write("Brand: ");
            allInOneComputer.Brand = Console.ReadLine();

            Console.Write("Model: ");
            allInOneComputer.Model = Console.ReadLine();

            Console.Write("Screen Size: ");
            allInOneComputer.ScreenSize = Console.ReadLine();

            Console.Write("Screen Type: ");
            allInOneComputer.ScreenType = Console.ReadLine();

            Console.Write("Screen Resolution Width: ");
            allInOneComputer.ScreenResolutionWidth = int.Parse(Console.ReadLine());

            Console.Write("Screen Resolution Height: ");
            allInOneComputer.ScreenResolutionHeight = int.Parse(Console.ReadLine());

            Console.Write("Touch Screen: ");
            allInOneComputer.TouchScreen = Console.ReadLine();

            Console.Write("Matrix Type: ");
            allInOneComputer.MatrixType = Console.ReadLine();

            Console.Write("Processor Manufacturer: ");
            allInOneComputer.ProcessorManufacturer = Console.ReadLine();

            Console.Write("Type of Processor: ");
            allInOneComputer.TypeOfProcessor = Console.ReadLine();

            Console.Write("Model Of Processor: ");
            allInOneComputer.ModelOfProcessor = Console.ReadLine();

            Console.Write("Number Of Cores: ");
            allInOneComputer.Cores = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number Of Threads: ");
            allInOneComputer.Thread = Convert.ToInt32(Console.ReadLine());

            Console.Write("CPU Frequency: ");
            allInOneComputer.CPUFrequency = Console.ReadLine();

            Console.Write("RAM (in GB): ");
            allInOneComputer.RAM = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type Of RAM Memory: ");
            allInOneComputer.TypeOfRAMMemory = Console.ReadLine();

            Console.Write("RAM Memory Speed: ");
            allInOneComputer.RAMMemorySpeed = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hard Drive/SSD: ");
            allInOneComputer.HardDriveSSD = Console.ReadLine();

            Console.Write("SSD Interface: ");
            allInOneComputer.SSDInterface = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type Of Video Adapter: ");
            allInOneComputer.TypeOfVideoAdapter = Console.ReadLine();

            Console.Write("Graphic Controller: ");
            allInOneComputer.GraphicController = Console.ReadLine();

            Console.Write("Interface: ");
            allInOneComputer.Interface = Console.ReadLine();

            Console.Write("Operating System: ");
            allInOneComputer.OperatingSystem = Console.ReadLine();

            Console.Write("Connectivity: ");
            allInOneComputer.Connectivity = Console.ReadLine();

            Console.Write("Dimensions: ");
            allInOneComputer.Dimensions = Console.ReadLine();

            Console.Write("Weight (in kg): ");
            allInOneComputer.Weight = Console.ReadLine();

            Console.Write("Color: ");
            allInOneComputer.Color = Console.ReadLine();

            Console.Write("Included Accessories: ");
            allInOneComputer.IncludedAccessories = Console.ReadLine();

            Console.Write("Price: ");
            allInOneComputer.Price = double.Parse(Console.ReadLine());

            
            devices.Add(allInOneComputer);
        }

        public void AddCase(List<ElectronicDevice> devices)
        {
            Case newCase = new Case();

            
            Console.WriteLine("Enter Case Details:");
            Console.Write("Brand: ");
            newCase.Brand = Console.ReadLine();

            Console.Write("Model: ");
            newCase.Model = Console.ReadLine();

            Console.Write("Case Type: ");
            newCase.CaseType = Console.ReadLine();

            Console.Write("Motherboard Form Factor: ");
            newCase.MotherboardFormFactor = Console.ReadLine();

            Console.Write("Cooling: ");
            newCase.Cooling = Console.ReadLine();

            Console.Write("Interface/Buttons: ");
            newCase.InterfaceButtons = Console.ReadLine();

            Console.Write("Liquid Cooling Compatibility (true/false): ");
            newCase.LiquidCoolingCompatibility = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Dimensions: ");
            newCase.Dimensions = Console.ReadLine();

            Console.Write("Weight (in kg): ");
            newCase.Weight = double.Parse(Console.ReadLine());

            Console.Write("Color: ");
            newCase.Color = Console.ReadLine();

            Console.Write("Price: ");
            newCase.Price = int.Parse(Console.ReadLine());
            devices.Add(newCase);
        }
        public void AddCooler(List<ElectronicDevice> devices)
        {
            Cooler cooler = new Cooler();

            
            Console.WriteLine("Enter Cooler Details:");
            Console.Write("Destination: ");
            cooler.Destination = Console.ReadLine();

            Console.Write("Socket Compatibility: ");
            cooler.SocketCompatibility = Console.ReadLine();

            Console.Write("Number Of Fan: ");
            cooler.NumberOfFan = Convert.ToInt32(Console.ReadLine());

            Console.Write("Rotational Speed (RPM): ");
            cooler.RotationalSpeed = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fan Dimensions: ");
            cooler.FanDimensions = Console.ReadLine();

            Console.Write("Fan Noise Level: ");
            cooler.FanNoiseLevel = Console.ReadLine();

            Console.Write("Lighting: ");
            cooler.Lighting = Console.ReadLine();

            
            devices.Add(cooler);
        }
        public void AddCPU(List<ElectronicDevice> devices)
        {
            CPU cpu = new CPU();

            
            Console.WriteLine("Enter CPU Details:");
            Console.Write("Processor: ");
            cpu.Processor = Console.ReadLine();

            Console.Write("Model Name: ");
            cpu.ModelName = Convert.ToInt32(Console.ReadLine());

            Console.Write("Processor Speed (GHz): ");
            cpu.ProcessorSpeed = Convert.ToDouble(Console.ReadLine());

            Console.Write("Max Processor Speed (GHz): ");
            cpu.MaxProcessorSpeed = Convert.ToDouble(Console.ReadLine());

            Console.Write("Number Of Cores: ");
            cpu.Cores = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number Of Threads: ");
            cpu.Thread = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cache (Mb): ");
            cpu.Cache = Convert.ToInt32(Console.ReadLine());

            Console.Write("Memory Types: ");
            cpu.MemoryTypes = Console.ReadLine();

            Console.Write("Max Memory Size (GB): ");
            cpu.MaxMemorySize = Convert.ToInt32(Console.ReadLine());

            Console.Write("Integrated Graphic Card: ");
            cpu.IntegratedGraphicCard = Console.ReadLine();

            Console.Write("Graphic Card Model: ");
            cpu.GraphicCardModel = Console.ReadLine();

            Console.Write("Socket: ");
            cpu.Socket = Convert.ToInt32(Console.ReadLine());

            Console.Write("PCI Express Version: ");
            cpu.PCIExpressVersion = Convert.ToDouble(Console.ReadLine());

            Console.Write("TDP (W MAX): ");
            cpu.TDP = Convert.ToInt32(Console.ReadLine());

            
            devices.Add(cpu);
        }
        public void AddGPU(List<ElectronicDevice> devices)
        {
            GPU gpu = new GPU();

            
            Console.WriteLine("Enter GPU Details:");
            Console.Write("Graphic Engine: ");
            gpu.GraphicEngine = Console.ReadLine();

            Console.Write("Graphic Engine Model: ");
            gpu.GraphicEngineModel = Console.ReadLine();

            Console.Write("GPU Clock (MHz): ");
            gpu.GPUClock = Convert.ToDouble(Console.ReadLine());

            Console.Write("Boost Clock (MHz): ");
            gpu.BoostClock = Convert.ToDouble(Console.ReadLine());

            Console.Write("Memory Type: ");
            gpu.MemoryType = Console.ReadLine();

            Console.Write("Memory (GB): ");
            gpu.Memory = Convert.ToInt32(Console.ReadLine());

            Console.Write("Memory Interface Width (bit): ");
            gpu.MemoryInterfaceWidth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cooling System: ");
            gpu.CoolingSystem = Console.ReadLine();

            Console.Write("Interface: ");
            gpu.Interface = Console.ReadLine();

            Console.Write("Video Card Interface: ");
            gpu.VideoCardInterface = Console.ReadLine();

            Console.Write("Dimensions: ");
            gpu.Dimensions = Console.ReadLine();

            
            devices.Add(gpu);
        }
        public void AddHardDrive(List<ElectronicDevice> devices)
        {
            HardDrive hardDrive = new HardDrive();

            
            Console.WriteLine("Enter Hard Drive Details:");
            Console.Write("Type: ");
            hardDrive.Type = Console.ReadLine();

            Console.Write("Form Factor: ");
            hardDrive.FormFactor = Console.ReadLine();

            Console.Write("Storage Capacity (GB): ");
            hardDrive.StorageCapacity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hard Drive Type: ");
            hardDrive.HardDriveType = Console.ReadLine();

            Console.Write("PCle: ");
            hardDrive.PCle = Console.ReadLine();

            Console.Write("Dimensions: ");
            hardDrive.Dimensions = Console.ReadLine();

            Console.Write("Weight (kg): ");
            hardDrive.Weight = Convert.ToDouble(Console.ReadLine());

            
            devices.Add(hardDrive);
        }
        public void AddMotherboard(List<ElectronicDevice> devices)
        {
            Motherboard motherboard = new Motherboard();

            
            Console.WriteLine("Enter Motherboard Details:");
            Console.Write("Model Name: ");
            motherboard.ModelName = Console.ReadLine();

            Console.Write("Form Factor: ");
            motherboard.FormFactor = Console.ReadLine();

            Console.Write("Socket: ");
            motherboard.Socket = Convert.ToInt32(Console.ReadLine());

            Console.Write("Chipset: ");
            motherboard.Chipset = Console.ReadLine();

            Console.Write("Compatibility Processors: ");
            motherboard.CompatibilityProcessors = Console.ReadLine();

            Console.Write("Max Memory (GB): ");
            motherboard.MaxMemory = Convert.ToInt32(Console.ReadLine());

            Console.Write("Memory Type: ");
            motherboard.MemoryType = Console.ReadLine();

            Console.Write("Max Memory MHz: ");
            motherboard.MaxMemoryMHz = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number Of Memory Slots: ");
            motherboard.NumberOfMemorySlots = Convert.ToInt32(Console.ReadLine());

            Console.Write("Memory Slots Type: ");
            motherboard.MemorySlotsType = Console.ReadLine();

            Console.Write("Version of PCI Express: ");
            motherboard.VersionOfPCIExpress = Console.ReadLine();

            Console.Write("Included Accessories: ");
            motherboard.IncludedAccessories = Console.ReadLine();

            Console.Write("Operating System: ");
            motherboard.OperatingSystem = Console.ReadLine();

            Console.Write("Dimensions Width (Width x Height in cm): ");
            motherboard.DimensionsWidth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dimensions Height (Width x Height in cm): ");
            motherboard.DimensionsHeight = Convert.ToInt32(Console.ReadLine());
            


            devices.Add(motherboard);
        }
        public void AddPowerSupply(List<ElectronicDevice> devices)
        {
            PowerSupply powerSupply = new PowerSupply();

            
            Console.WriteLine("Enter Power Supply Details:");
            Console.Write("Form Factor: ");
            powerSupply.FormFactor = Console.ReadLine();

            Console.Write("Watts: ");
            powerSupply.Watts = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Voltage: ");
            powerSupply.InputVoltage = Console.ReadLine();

            Console.Write("Input Frequency Range: ");
            powerSupply.InputFrequencyRange = Console.ReadLine();

            Console.Write("Power Connectors (CPU): ");
            powerSupply.PowerConnectorsCPU = Console.ReadLine();

            Console.Write("PFC: ");
            powerSupply.PFC = Console.ReadLine();

            
            devices.Add(powerSupply);
        }
        public void AddRAM(List<ElectronicDevice> devices)
        {
            RAM ram = new RAM();

            
            Console.WriteLine("Enter RAM Details:");
            Console.Write("Compatibility: ");
            ram.Compatibility = Console.ReadLine();

            Console.Write("Form Factor: ");
            ram.FormFactor = Console.ReadLine();

            Console.Write("Volume (GB): ");
            ram.Volume = Convert.ToInt32(Console.ReadLine());

            Console.Write("Memory Type: ");
            ram.MemoryType = Console.ReadLine();

            Console.Write("Memory Clock (MHz): ");
            ram.MemoryClock = Convert.ToInt32(Console.ReadLine());

            Console.Write("Radiator: ");
            ram.Radiator = Console.ReadLine();

            
            devices.Add(ram);
        }
        public void AddLaptop(List<ElectronicDevice> devices)
        {
            Laptop laptop = new Laptop();

            Console.WriteLine("Enter Laptop Details:");
            Console.Write("Brand: ");
            laptop.Brand = Console.ReadLine();

            Console.Write("Model: ");
            laptop.Model = Console.ReadLine();

            Console.Write("Type: ");
            laptop.Type = Console.ReadLine();

            Console.Write("Screen Size (inches): ");
            laptop.ScreenSize = Convert.ToInt32(Console.ReadLine());

            Console.Write("Screen Type: ");
            laptop.ScreenType = Console.ReadLine();

            Console.Write("Screen Resolution X: ");
            laptop.ScreenResolutionX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Screen Resolution Y: ");
            laptop.ScreenResolutionY = Convert.ToInt32(Console.ReadLine());

            Console.Write("Touch Support (Yes/No): ");
            laptop.Touch = Console.ReadLine();

            Console.Write("Matrix Type: ");
            laptop.MatrixType = Console.ReadLine();

            Console.Write("Refresh Rate (Hz): ");
            laptop.RefreshRate = Convert.ToInt32(Console.ReadLine());

            Console.Write("Processor: ");
            laptop.Processor = Console.ReadLine();

            Console.Write("Processor Model: ");
            laptop.ProcessorModel = Console.ReadLine();

            Console.Write("Processor Speed: ");
            laptop.ProcessorSpeed = Console.ReadLine();

            Console.Write("Number of Cores: ");
            laptop.NumberOfCores = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of Threads: ");
            laptop.NumberOfThreads = Convert.ToInt32(Console.ReadLine());

            Console.Write("RAM (GB): ");
            laptop.RAM = Convert.ToInt32(Console.ReadLine());

            Console.Write("RAM Type: ");
            laptop.RAMType = Console.ReadLine();

            Console.Write("Hard Drive Type: ");
            laptop.HardDriveType = Console.ReadLine();

            Console.Write("Hard Drive Capacity (GB): ");
            laptop.HardDriveCapacity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Video Adapter Type: ");
            laptop.VideoAdapterType = Console.ReadLine();

            Console.Write("GPU Model: ");
            laptop.GPUModel = Console.ReadLine();

            Console.Write("Video Memory (GB): ");
            laptop.VideoMemory = Convert.ToInt32(Console.ReadLine());

            Console.Write("Interface: ");
            laptop.Interface = Console.ReadLine();

            Console.Write("Operating System: ");
            laptop.OperatingSystem = Console.ReadLine();

            Console.Write("Optical Drive: ");
            laptop.OpticalDrive = Console.ReadLine();

            Console.Write("Connectivity: ");
            laptop.Connectivity = Console.ReadLine();

            Console.Write("Weight: ");
            laptop.Weight = Console.ReadLine();

            Console.Write("Color: ");
            laptop.Color = Console.ReadLine();

            devices.Add(laptop);
        }
        public void AddTablet(List<ElectronicDevice> devices)
        {
            Tablet tablet = new Tablet();

            Console.WriteLine("Enter Tablet Details:");
            Console.Write("Brand: ");
            tablet.Brand = Console.ReadLine();

            Console.Write("Model: ");
            tablet.Model = Console.ReadLine();

            Console.Write("Screen Size (inches): ");
            tablet.ScreenSize = Convert.ToDouble(Console.ReadLine());

            Console.Write("Screen Resolution X: ");
            tablet.ScreenResolutionX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Screen Resolution Y: ");
            tablet.ScreenResolutionY = Convert.ToInt32(Console.ReadLine());

            Console.Write("PPI: ");
            tablet.PPI = Convert.ToInt32(Console.ReadLine());

            Console.Write("Panel Type: ");
            tablet.PanelType = Console.ReadLine();

            Console.Write("SIM Type: ");
            tablet.SIMType = Console.ReadLine();

            Console.Write("Processor: ");
            tablet.Processor = Console.ReadLine();

            Console.Write("Processor Speed: ");
            tablet.ProcessorSpeed = Console.ReadLine();

            Console.Write("RAM (GB): ");
            tablet.RAM = Convert.ToInt32(Console.ReadLine());

            Console.Write("Internal Memory (GB): ");
            tablet.InternalMemory = Convert.ToInt32(Console.ReadLine());

            Console.Write("Memory Card Support: ");
            tablet.MemoryCardSupport = Console.ReadLine();

            Console.Write("Camera (MP): ");
            tablet.Camera = Convert.ToInt32(Console.ReadLine());

            Console.Write("Frontal Camera (MP): ");
            tablet.FrontalCamera = Convert.ToInt32(Console.ReadLine());

            Console.Write("Interface: ");
            tablet.Interface = Console.ReadLine();

            Console.Write("Type Of Battery: ");
            tablet.TypeOfBattery = Console.ReadLine();

            Console.Write("Operating System: ");
            tablet.OperatingSystem = Console.ReadLine();

            Console.Write("Sensors: ");
            tablet.Sensors = Console.ReadLine();

            Console.Write("Communication: ");
            tablet.Communication = Console.ReadLine();

            Console.Write("Size: ");
            tablet.Size = Console.ReadLine();

            Console.Write("Weight: ");
            tablet.Weight = Console.ReadLine();

            Console.Write("Color: ");
            tablet.Color = Console.ReadLine();

            devices.Add(tablet);
        }
        public void AddPhone(List<ElectronicDevice> devices)
        {
            Phone phone = new Phone();

            Console.WriteLine("Enter Phone Details:");
            Console.Write("Brand: ");
            phone.Brand = Console.ReadLine();

            Console.Write("Model: ");
            phone.Model = Console.ReadLine();

            Console.Write("Screen Type: ");
            phone.ScreenType = Console.ReadLine();

            Console.Write("Screen Size (inches): ");
            phone.ScreenSize = Convert.ToDouble(Console.ReadLine());

            Console.Write("Resolution: ");
            phone.Resolution = Console.ReadLine();

            Console.Write("Update Frequency (Hz): ");
            phone.UpdateFrequency = Convert.ToInt32(Console.ReadLine());

            Console.Write("RAM Capacity (GB): ");
            phone.RAMCapacity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Internal Memory Capacity (GB): ");
            phone.InternalMemoryCapacity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Memory Card Support: ");
            phone.MemoryCardSupport = Console.ReadLine();

            Console.Write("Chipset: ");
            phone.Chipset = Console.ReadLine();

            Console.Write("Graphics Processor: ");
            phone.GraphicsProcessor = Console.ReadLine();

            Console.Write("Processor: ");
            phone.Processor = Console.ReadLine();

            Console.Write("Operating System: ");
            phone.OperatingSystem = Console.ReadLine();

            Console.Write("Video: ");
            phone.Video = Console.ReadLine();

            Console.Write("Camera (MP): ");
            phone.Camera = Convert.ToInt32(Console.ReadLine());

            Console.Write("Additional Features: ");
            phone.AdditionalFeatures = Console.ReadLine();

            Console.Write("Selfie Camera (MP): ");
            phone.SelfieCamera = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type: ");
            phone.Type = Console.ReadLine();

            Console.Write("Item Volume (cm^3): ");
            phone.ItemVolume = Convert.ToDouble(Console.ReadLine());

            Console.Write("Item Type: ");
            phone.ItemType = Console.ReadLine();

            Console.Write("Ports: ");
            phone.Ports = Console.ReadLine();

            Console.Write("Wi-Fi (Yes/No): ");
            phone.WiFi = Console.ReadLine().Equals("Yes", StringComparison.OrdinalIgnoreCase);

            Console.Write("GPS (Yes/No): ");
            phone.GPS = Console.ReadLine().Equals("Yes", StringComparison.OrdinalIgnoreCase);

            Console.Write("NFC (Yes/No): ");
            phone.NFC = Console.ReadLine().Equals("Yes", StringComparison.OrdinalIgnoreCase);

            Console.Write("Bluetooth (Yes/No): ");
            phone.Bluetooth = Console.ReadLine().Equals("Yes", StringComparison.OrdinalIgnoreCase);

            Console.Write("Technology: ");
            phone.Technology = Console.ReadLine();

            Console.Write("Sensors: ");
            phone.Sensors = Console.ReadLine();

            Console.Write("Weight (g): ");
            phone.Weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Color: ");
            phone.Color = Console.ReadLine();

            Console.Write("Size: ");
            phone.Size = Console.ReadLine();

            Console.Write("Body Material: ");
            phone.BodyMaterial = Console.ReadLine();

            devices.Add(phone);
        }

        public void AddPerson(List<Person> people)
        {
            AddXmlFile addXmlFile = new AddXmlFile();
            

            Authorization authorization = new Authorization();
            
            User user = new User();

            Console.WriteLine("User Registration\n");

            Console.Write("Enter User Name: ");
            user.UserName = Console.ReadLine();

            Console.Write("Enter Password: ");
            user.Password = Console.ReadLine();

            Console.Write("Enter First Name: ");
            user.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            user.LastName = Console.ReadLine();

            Console.Write("Enter Age: ");
            user.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Mail: ");
            user.Mail = Console.ReadLine();

            var validationErrors = authorization.Validation(user);
            if (validationErrors != "successful")
            {
                Console.WriteLine($"User registration failed due to validation errors:\n{validationErrors}");
            }
            else
            {
                string rootFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Store", "model", "Person", "registered_users");
                string userFolderPath = Path.Combine(rootFolderPath, user.UserName);

                if (!Directory.Exists(userFolderPath))
                {
                    
                    Directory.CreateDirectory(userFolderPath);
                    Console.WriteLine("User registered successfully");
                    addXmlFile.UserAddXml(new List<Person> { user });
                }
                else
                {
                    Console.WriteLine("This user already exists");
                }

            }



        }
        public void AddAdmin(List<Person> people)
        {
            AddXmlFile addXmlFile = new AddXmlFile();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\Person\registered_admins.xml";
            if (File.Exists(path))
            {
                loadXmlFile.UserLoadXml(path);
                people.AddRange(loadXmlFile.UserLoadXml(path));
            }
            else
            {
                Console.WriteLine("User information XML file does not exist. Skipping loading.");
            }

            Authorization authorization = new Authorization();

            Admin user = new Admin();

            Console.WriteLine("Admin Registration\n");

            Console.Write("Enter User Name: ");
            user.UserName = Console.ReadLine();

            Console.Write("Enter Password: ");
            user.Password = Console.ReadLine();

            Console.Write("Enter First Name: ");
            user.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            user.LastName = Console.ReadLine();

            Console.Write("Enter Age: ");
            user.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Mail: ");
            user.Mail = Console.ReadLine();

            var validationErrors = authorization.Validation(user);
            if (validationErrors != "successful")
            {
                Console.WriteLine($"Admin registration failed due to validation errors:\n{validationErrors}");
            }
            else
            {
                var find = people.FirstOrDefault(p => p.UserName == user.UserName);
                if (find == null)
                {
                    people.Add(user);
                    Console.WriteLine("Admin registered successfully");
                    addXmlFile.AdminAddXml(people);
                }
                else
                {
                    Console.WriteLine("This Admin already exists");
                }

            }
        }
    }
}
