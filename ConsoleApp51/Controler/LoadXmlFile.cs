using ConsoleApp51.Device.Computer;
using ConsoleApp51.Device.ComputerParts;
using ConsoleApp51.Device.Tablet;
using ConsoleApp51.Model.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp51.Controler
{
    internal class LoadXmlFile
    {
        public List<Person> UserLoadXml(string path) 
        {
            List<Person> people = new List<Person>();

            XDocument xDocument = XDocument.Load(path);

            foreach (XElement element in xDocument.Descendants("User"))
            {
                string userName = element.Element("UserName")?.Value;
                string password = element.Element("Password")?.Value;
                string firsName = element.Element("FirstName")?.Value;
                string lastName = element.Element("LastName")?.Value;
                int age = int.Parse(element.Element("Age")?.Value);
                string mail = element.Element("Mail")?.Value;

                User user = new User()
                {
                    UserName = userName,
                    Password = password,
                    FirstName = firsName,
                    LastName = lastName,
                    Age = age,
                    Mail = mail
                };
                people.Add(user);
            }
            return people;
        }
        public List<Person> AdminLoadXml(string path)
        {
            List<Person> people = new List<Person>();

            XDocument xDocument = XDocument.Load(path);

            foreach (XElement element in xDocument.Descendants("Admin"))
            {
                string userName = element.Element("UserName")?.Value;
                string password = element.Element("Password")?.Value;
                string firsName = element.Element("FirstName")?.Value;
                string lastName = element.Element("LastName")?.Value;
                int age = int.Parse(element.Element("Age")?.Value);
                string mail = element.Element("Mail")?.Value;

                Admin admin = new Admin()
                {
                    UserName = userName,
                    Password = password,
                    FirstName = firsName,
                    LastName = lastName,
                    Age = age,
                    Mail = mail
                };
                people.Add(admin);
            }
            return people;
        }
        public List<ElectronicDevice> ComputerLoadXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\Computer\Computer.xml";
            List<ElectronicDevice> computers = new List<ElectronicDevice>();

            XDocument xDocument = XDocument.Load(path);

            foreach (XElement element in xDocument.Descendants("Computer"))
            {
                int deviceId = int.Parse(element.Element("DeviceId")?.Value ?? "0");
                string brand = element.Element("Brand")?.Value;
                string model = element.Element("Model")?.Value;
                string processorManufacturer = element.Element("ProcessorManufacturer")?.Value;
                string typeOfProcessor = element.Element("TypeOfProcessor")?.Value;
                int modelOfProcessor = int.Parse(element.Element("ModelOfProcessor")?.Value);
                int cores = int.Parse(element.Element("Cores")?.Value ?? "0");
                int threads = int.Parse(element.Element("Thread")?.Value ?? "0");
                string cpuFrequency = element.Element("CPUFrequency")?.Value ?? "0";
                int ram = int.Parse(element.Element("RAM")?.Value ?? "0");
                string typeOfRAMMemory = element.Element("TypeOfRAMMemory")?.Value;
                int ramMemorySpeed = int.Parse(element.Element("RAMMemorySpeed")?.Value ?? "0");
                string hardDriveSSD = element.Element("HardDriveSSD")?.Value;
                int ssdInterface = int.Parse(element.Element("SSDInterface")?.Value);
                string typeOfVideoAdapter = element.Element("TypeOfVideoAdapter")?.Value;
                string graphicController = element.Element("GraphicController")?.Value;
                string interfaceType = element.Element("Interface")?.Value;
                string operatingSystem = element.Element("OperatingSystem")?.Value;
                string connectivity = element.Element("Connectivity")?.Value;
                string dimensions = element.Element("Dimensions")?.Value;
                double weight = double.Parse(element.Element("Weight")?.Value ?? "0");
                string color = element.Element("Color")?.Value;
                string includedAccessories = element.Element("IncludedAccessories")?.Value;
                int price = int.Parse(element.Element("Price")?.Value ?? "0");

                Computer computer = new Computer
                {
                    DeviceId = deviceId,
                    Brand = brand,
                    Model = model,
                    ProcessorManufacturer = processorManufacturer,
                    TypeOfProcessor = typeOfProcessor,
                    ModelOfProcessor = modelOfProcessor,
                    Cores = cores,
                    Thread = threads,
                    CPUFrequency = cpuFrequency,
                    RAM = ram,
                    TypeOfRAMMemory = typeOfRAMMemory,
                    RAMMemorySpeed = ramMemorySpeed,
                    HardDriveSSD = hardDriveSSD,
                    SSDInterface = ssdInterface,
                    TypeOfVideoAdapter = typeOfVideoAdapter,
                    GraphicController = graphicController,
                    Interface = interfaceType,
                    OperatingSystem = operatingSystem,
                    Connectivity = connectivity,
                    Dimensions = dimensions,
                    Weight = weight,
                    Color = color,
                    IncludedAccessories = includedAccessories,
                    Price = price,
                };

                computers.Add(computer);
            }

            return computers;
        }
        public List<ElectronicDevice> AllInOneComputerLoadXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\Computer\AllInOneComputer.xml";
            List<ElectronicDevice> allInOneComputers = new List<ElectronicDevice>();

            XDocument xDocument = XDocument.Load(path);

            foreach (XElement element in xDocument.Descendants("AllInOneComputer"))
            {
                int deviceId = int.Parse(element.Element("DeviceId")?.Value ?? "0");
                string brand = element.Element("Brand")?.Value;
                string model = element.Element("Model")?.Value;
                string screenSize = element.Element("ScreenSize")?.Value;
                string screenType = element.Element("ScreenType")?.Value;
                int screenResolutionWidth = int.Parse(element.Element("ScreenResolutionWidth")?.Value ?? "0");
                int screenResolutionHeight = int.Parse(element.Element("ScreenResolutionHeight")?.Value ?? "0");
                string touchScreen = element.Element("TouchScreen")?.Value;
                string matrixType = element.Element("MatrixType")?.Value;
                string processorManufacturer = element.Element("ProcessorManufacturer")?.Value;
                string typeOfProcessor = element.Element("TypeOfProcessor")?.Value;
                string modelOfProcessor = element.Element("ModelOfProcessor")?.Value;
                int cores = int.Parse(element.Element("Cores")?.Value ?? "0");
                int threads = int.Parse(element.Element("Thread")?.Value ?? "0");
                string cpuFrequency = element.Element("CPUFrequency")?.Value ?? "0";
                int ram = int.Parse(element.Element("RAM")?.Value ?? "0");
                string typeOfRAMMemory = element.Element("TypeOfRAMMemory")?.Value;
                int ramMemorySpeed = int.Parse(element.Element("RAMMemorySpeed")?.Value ?? "0");
                string hardDriveSSD = element.Element("HardDriveSSD")?.Value;
                int ssdInterface = int.Parse(element.Element("SSDInterface")?.Value ?? "0");
                string typeOfVideoAdapter = element.Element("TypeOfVideoAdapter")?.Value;
                string graphicController = element.Element("GraphicController")?.Value;
                string interfaceType = element.Element("Interface")?.Value;
                string operatingSystem = element.Element("OperatingSystem")?.Value;
                string connectivity = element.Element("Connectivity")?.Value;
                string dimensions = element.Element("Dimensions")?.Value;
                string weight = element.Element("Weight")?.Value ?? "0";
                string color = element.Element("Color")?.Value;
                string includedAccessories = element.Element("IncludedAccessories")?.Value;
                double price = int.Parse(element.Element("Price")?.Value ?? "0");

                AllInOneComputer allInOneComputer = new AllInOneComputer
                {
                    DeviceId = deviceId,
                    Brand = brand,
                    Model = model,
                    ScreenSize = screenSize,
                    ScreenType = screenType,
                    ScreenResolutionWidth = screenResolutionWidth,
                    ScreenResolutionHeight = screenResolutionHeight,
                    TouchScreen = touchScreen,
                    MatrixType = matrixType,
                    ProcessorManufacturer = processorManufacturer,
                    TypeOfProcessor = typeOfProcessor,
                    ModelOfProcessor = modelOfProcessor,
                    Cores = cores,
                    Thread = threads,
                    CPUFrequency = cpuFrequency,
                    RAM = ram,
                    TypeOfRAMMemory = typeOfRAMMemory,
                    RAMMemorySpeed = ramMemorySpeed,
                    HardDriveSSD = hardDriveSSD,
                    SSDInterface = ssdInterface,
                    TypeOfVideoAdapter = typeOfVideoAdapter,
                    GraphicController = graphicController,
                    Interface = interfaceType,
                    OperatingSystem = operatingSystem,
                    Connectivity = connectivity,
                    Dimensions = dimensions,
                    Weight = weight,
                    Color = color,
                    IncludedAccessories = includedAccessories,
                    Price = price
                };

                allInOneComputers.Add(allInOneComputer);
            }

            return allInOneComputers;
        }
        public List<ElectronicDevice> ConsolesLoadXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\Computer\Consoles.xml";
            List<ElectronicDevice> consoles = new List<ElectronicDevice>();

            XDocument xDocument = XDocument.Load(path);

            foreach (XElement element in xDocument.Descendants("Console"))
            {
                int deviceId = int.Parse(element.Element("DeviceId")?.Value ?? "0");
                string brand = element.Element("Brand")?.Value;
                string model = element.Element("Model")?.Value;
                string typeOfChipset = element.Element("TypeOfChipset")?.Value;
                int numberOfCores = int.Parse(element.Element("NumberOfCores")?.Value ?? "0");
                int ram = int.Parse(element.Element("RAM")?.Value ?? "0");
                string typeOfRAMMemory = element.Element("TypeOfRAMMemory")?.Value;
                string graphicController = element.Element("GraphicController")?.Value;
                string typeOfMemory = element.Element("TypeOfMemory")?.Value;
                string interfaceType = element.Element("Interface")?.Value;
                string opticalDrive = element.Element("OpticalDrive")?.Value;
                string connectivity = element.Element("Connectivity")?.Value;
                string dimensions = element.Element("Dimensions")?.Value;
                double weight = double.Parse(element.Element("Weight")?.Value ?? "0");
                string color = element.Element("Color")?.Value;
                double price = double.Parse(element.Element("Price")?.Value ?? "0");

                Consoles console = new Consoles
                {
                    DeviceId = deviceId,
                    Brand = brand,
                    Model = model,
                    TypeOfChipset = typeOfChipset,
                    NumberOfCores = numberOfCores,
                    RAM = ram,
                    TypeOfRAMMemory = typeOfRAMMemory,
                    GraphicController = graphicController,
                    TypeOfMemory = typeOfMemory,
                    Interface = interfaceType,
                    OpticalDrive = opticalDrive,
                    Connectivity = connectivity,
                    Dimensions = dimensions,
                    Weight = weight,
                    Color = color,
                    Price = price
                };

                consoles.Add(console);
            }

            return consoles;
        }
        public List<ElectronicDevice> CaseLoadXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\ComputerParts\Case.xml";
            List<ElectronicDevice> cases = new List<ElectronicDevice>();

            XDocument xDocument = XDocument.Load(path);

            foreach (XElement element in xDocument.Descendants("Case"))
            {
                int deviceId = int.Parse(element.Element("DeviceId")?.Value);
                string brand = element.Element("Brand")?.Value;
                string model = element.Element("Model")?.Value;
                string caseType = element.Element("CaseType")?.Value;
                string motherboardFormFactor = element.Element("MotherboardFormFactor")?.Value;
                string cooling = element.Element("Cooling")?.Value;
                string interfaceButtons = element.Element("InterfaceButtons")?.Value;
                bool liquidCoolingCompatibility = bool.Parse(element.Element("LiquidCoolingCompatibility")?.Value ?? "false");
                string dimensions = element.Element("Dimensions")?.Value;
                double weight = double.Parse(element.Element("Weight")?.Value ?? "0");
                string color = element.Element("Color")?.Value;
                double price = int.Parse(element.Element("Price")?.Value ?? "0");

                Case computerCase = new Case
                {
                    DeviceId = deviceId,
                    Brand = brand,
                    Model = model,
                    CaseType = caseType,
                    MotherboardFormFactor = motherboardFormFactor,
                    Cooling = cooling,
                    InterfaceButtons = interfaceButtons,
                    LiquidCoolingCompatibility = liquidCoolingCompatibility,
                    Dimensions = dimensions,
                    Weight = weight,
                    Color = color,
                    Price = price,
                };

                cases.Add(computerCase);
            }

            return cases;
        }
        public List<ElectronicDevice> CoolerLoadXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\ComputerParts\Cooler.xml";
            List<ElectronicDevice> coolers = new List<ElectronicDevice>();

            XDocument xDocument = XDocument.Load(path);

            foreach (XElement element in xDocument.Descendants("Cooler"))
            {
                int deviceId = int.Parse(element.Element("DeviceId")?.Value);
                string destination = element.Element("Destination")?.Value;
                string socketCompatibility = element.Element("SocketCompatibility")?.Value;
                int numberOfFan = int.Parse(element.Element("NumberOfFan")?.Value ?? "0");
                int rotationalSpeed = int.Parse(element.Element("RotationalSpeed")?.Value ?? "0");
                string fanDimensions = element.Element("FanDimensions")?.Value;
                string fanNoiseLevel = element.Element("FanNoiseLevel")?.Value;
                string lighting = element.Element("Lighting")?.Value;
                double price = int.Parse(element.Element("Price")?.Value ?? "0");

                Cooler cooler = new Cooler
                {
                    DeviceId = deviceId,
                    Destination = destination,
                    SocketCompatibility = socketCompatibility,
                    NumberOfFan = numberOfFan,
                    RotationalSpeed = rotationalSpeed,
                    FanDimensions = fanDimensions,
                    FanNoiseLevel = fanNoiseLevel,
                    Lighting = lighting,
                    Price = price,
                };

                coolers.Add(cooler);
            }

            return coolers;
        }
        public List<ElectronicDevice> CPULoadXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\ComputerParts\CPU.xml";
            List<ElectronicDevice> cpus = new List<ElectronicDevice>();

            XDocument xDocument = XDocument.Load(path);

            foreach (XElement element in xDocument.Descendants("CPU"))
            {
                int deviceId = int.Parse(element.Element("DeviceId")?.Value);
                string processor = element.Element("Processor")?.Value;
                int modelName = int.Parse(element.Element("ModelName")?.Value ?? "0");
                double processorSpeed = double.Parse(element.Element("ProcessorSpeed")?.Value ?? "0");
                double maxProcessorSpeed = double.Parse(element.Element("MaxProcessorSpeed")?.Value ?? "0");
                int cores = int.Parse(element.Element("Cores")?.Value ?? "0");
                int thread = int.Parse(element.Element("Thread")?.Value ?? "0");
                int cache = int.Parse(element.Element("Cache")?.Value ?? "0");
                string memoryTypes = element.Element("MemoryTypes")?.Value;
                int maxMemorySize = int.Parse(element.Element("MaxMemorySize")?.Value ?? "0");
                string integratedGraphicCard = element.Element("IntegratedGraphicCard")?.Value;
                string graphicCardModel = element.Element("GraphicCardModel")?.Value;
                int socket = int.Parse(element.Element("Socket")?.Value ?? "0");
                double pciExpressVersion = double.Parse(element.Element("PCIExpressVersion")?.Value ?? "0");
                int tdp = int.Parse(element.Element("TDP")?.Value ?? "0");
                double price = int.Parse(element.Element("Price")?.Value ?? "0");

                CPU cpu = new CPU
                {    
                    DeviceId = deviceId,   
                    Processor = processor,
                    ModelName = modelName,
                    ProcessorSpeed = processorSpeed,
                    MaxProcessorSpeed = maxProcessorSpeed,
                    Cores = cores,
                    Thread = thread,
                    Cache = cache,
                    MemoryTypes = memoryTypes,
                    MaxMemorySize = maxMemorySize,
                    IntegratedGraphicCard = integratedGraphicCard,
                    GraphicCardModel = graphicCardModel,
                    Socket = socket,
                    PCIExpressVersion = pciExpressVersion,
                    TDP = tdp,
                    Price = price,
                };

                cpus.Add(cpu);
            }

            return cpus;
        }
        public List<ElectronicDevice> GPULoadXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\ComputerParts\GPU.xml";
            List<ElectronicDevice> gpus = new List<ElectronicDevice>();

            XDocument xDocument = XDocument.Load(path);

            foreach (XElement element in xDocument.Descendants("GPU"))
            {
                int deviceId = int.Parse(element.Element("DeviceId")?.Value);
                string graphicEngine = element.Element("GraphicEngine")?.Value;
                string graphicEngineModel = element.Element("GraphicEngineModel")?.Value;
                double gpuClock = double.Parse(element.Element("GPUClock")?.Value ?? "0");
                double boostClock = double.Parse(element.Element("BoostClock")?.Value ?? "0");
                string memoryType = element.Element("MemoryType")?.Value;
                int memory = int.Parse(element.Element("Memory")?.Value ?? "0");
                int memoryInterfaceWidth = int.Parse(element.Element("MemoryInterfaceWidth")?.Value ?? "0");
                string coolingSystem = element.Element("CoolingSystem")?.Value;
                string interfaceType = element.Element("Interface")?.Value;
                string videoCardInterface = element.Element("VideoCardInterface")?.Value;
                string dimensions = element.Element("Dimensions")?.Value;
                double price = int.Parse(element.Element("Price")?.Value ?? "0");

                GPU gpu = new GPU
                {
                    DeviceId = deviceId,
                    GraphicEngine = graphicEngine,
                    GraphicEngineModel = graphicEngineModel,
                    GPUClock = gpuClock,
                    BoostClock = boostClock,
                    MemoryType = memoryType,
                    Memory = memory,
                    MemoryInterfaceWidth = memoryInterfaceWidth,
                    CoolingSystem = coolingSystem,
                    Interface = interfaceType,
                    VideoCardInterface = videoCardInterface,
                    Dimensions = dimensions,
                    Price = price,
                };

                gpus.Add(gpu);
            }

            return gpus;
        }
        public List<ElectronicDevice> HardDriveLoadXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\ComputerParts\HardDrive.xml";
            List<ElectronicDevice> hardDrives = new List<ElectronicDevice>();

            XDocument xDocument = XDocument.Load(path);

            foreach (XElement element in xDocument.Descendants("HardDrive"))
            {
                int deviceId = int.Parse(element.Element("DeviceId")?.Value);
                string type = element.Element("Type")?.Value;
                string formFactor = element.Element("FormFactor")?.Value;
                int storageCapacity = int.Parse(element.Element("StorageCapacity")?.Value ?? "0");
                string hardDriveType = element.Element("HardDriveType")?.Value;
                string pcie = element.Element("PCle")?.Value;
                string dimensions = element.Element("Dimensions")?.Value;
                double weight = double.Parse(element.Element("Weight")?.Value ?? "0");
                double price = int.Parse(element.Element("Price")?.Value ?? "0");

                HardDrive hardDrive = new HardDrive
                {
                    DeviceId = deviceId,
                    Type = type,
                    FormFactor = formFactor,
                    StorageCapacity = storageCapacity,
                    HardDriveType = hardDriveType,
                    PCle = pcie,
                    Dimensions = dimensions,
                    Weight = weight,
                    Price = price
                };

                hardDrives.Add(hardDrive);
            }

            return hardDrives;
        }
        public List<ElectronicDevice> MotherboardLoadXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\ComputerParts\Motherboard.xml";
            List<ElectronicDevice> motherboards = new List<ElectronicDevice>();

            XDocument xDocument = XDocument.Load(path);

            foreach (XElement element in xDocument.Descendants("Motherboard"))
            {
                int deviceId = int.Parse(element.Element("DeviceId")?.Value);
                string modelName = element.Element("ModelName")?.Value;
                string formFactor = element.Element("FormFactor")?.Value;
                int socket = int.Parse(element.Element("Socket")?.Value ?? "0");
                string chipset = element.Element("Chipset")?.Value;
                string compatibilityProcessors = element.Element("CompatibilityProcessors")?.Value;
                int maxMemory = int.Parse(element.Element("MaxMemory")?.Value ?? "0");
                string memoryType = element.Element("MemoryType")?.Value;
                int maxMemoryMHz = int.Parse(element.Element("MaxMemoryMHz")?.Value ?? "0");
                int numberOfMemorySlots = int.Parse(element.Element("NumberOfMemorySlots")?.Value ?? "0");
                string memorySlotsType = element.Element("MemorySlotsType")?.Value;
                string versionOfPCIExpress = element.Element("VersionOfPCIExpress")?.Value;
                string includedAccessories = element.Element("IncludedAccessories")?.Value;
                string operatingSystem = element.Element("OperatingSystem")?.Value;
                int dimensionsWidth = int.Parse(element.Element("DimensionsWidth")?.Value ?? "0");
                int dimensionsHeight = int.Parse(element.Element("DimensionsHeight")?.Value ?? "0");
                double price = int.Parse(element.Element("Price")?.Value ?? "0");

                Motherboard motherboard = new Motherboard
                {
                    DeviceId = deviceId,
                    ModelName = modelName,
                    FormFactor = formFactor,
                    Socket = socket,
                    Chipset = chipset,
                    CompatibilityProcessors = compatibilityProcessors,
                    MaxMemory = maxMemory,
                    MemoryType = memoryType,
                    MaxMemoryMHz = maxMemoryMHz,
                    NumberOfMemorySlots = numberOfMemorySlots,
                    MemorySlotsType = memorySlotsType,
                    VersionOfPCIExpress = versionOfPCIExpress,
                    IncludedAccessories = includedAccessories,
                    OperatingSystem = operatingSystem,
                    DimensionsWidth = dimensionsWidth,
                    DimensionsHeight = dimensionsHeight,
                    Price = price,  
                };

                motherboards.Add(motherboard);
            }

            return motherboards;
        }
        public List<ElectronicDevice> PowerSupplyLoadXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\ComputerParts\PowerSupply.xml";
            List<ElectronicDevice> powerSupplies = new List<ElectronicDevice>();

            XDocument xDocument = XDocument.Load(path);

            foreach (XElement element in xDocument.Descendants("PowerSupply"))
            {
                int deviceId = int.Parse(element.Element("DeviceId")?.Value);
                string brand = element.Element("Brand")?.Value;
                string model = element.Element("Model")?.Value;
                string formFactor = element.Element("FormFactor")?.Value;
                int watts = int.Parse(element.Element("Watts")?.Value ?? "0");
                string inputVoltage = element.Element("InputVoltage")?.Value;
                string inputFrequencyRange = element.Element("InputFrequencyRange")?.Value;
                string powerConnectorsCPU = element.Element("PowerConnectorsCPU")?.Value;
                string pfc = element.Element("PFC")?.Value;
                double price = int.Parse(element.Element("Price")?.Value ?? "0");

                PowerSupply powerSupply = new PowerSupply
                {
                    DeviceId = deviceId,
                    Brand = brand,
                    Model = model,
                    FormFactor = formFactor,
                    Watts = watts,
                    InputVoltage = inputVoltage,
                    InputFrequencyRange = inputFrequencyRange,
                    PowerConnectorsCPU = powerConnectorsCPU,
                    PFC = pfc,
                    Price = price,
                };

                powerSupplies.Add(powerSupply);
            }

            return powerSupplies;
        }
        public List<ElectronicDevice> RAMLoadXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\ComputerParts\RAM.xml";
            List<ElectronicDevice> ramModules = new List<ElectronicDevice>();

            XDocument xDocument = XDocument.Load(path);

            foreach (XElement element in xDocument.Descendants("RAM"))
            {
                int deviceId = int.Parse(element.Element("DeviceId")?.Value);
                string compatibility = element.Element("Compatibility")?.Value;
                string formFactor = element.Element("FormFactor")?.Value;
                int volume = int.Parse(element.Element("Volume")?.Value ?? "0");
                string memoryType = element.Element("MemoryType")?.Value;
                int memoryClock = int.Parse(element.Element("MemoryClock")?.Value ?? "0");
                string radiator = element.Element("Radiator")?.Value;

                RAM ram = new RAM
                {
                    DeviceId = deviceId,
                    Compatibility = compatibility,
                    FormFactor = formFactor,
                    Volume = volume,
                    MemoryType = memoryType,
                    MemoryClock = memoryClock,
                    Radiator = radiator
                };

                ramModules.Add(ram);
            }

            return ramModules;
        }
        public List<ElectronicDevice> LaptopLoadXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\Tablet\Laptop.xml";
            List<ElectronicDevice> laptops = new List<ElectronicDevice>();

            XDocument xDocument = XDocument.Load(path);

            foreach (XElement element in xDocument.Descendants("Laptop"))
            {
                Laptop laptop = new Laptop
                {
                    DeviceId = int.Parse(element.Element("DeviceId")?.Value),
                    Brand = element.Element("Brand")?.Value,
                    Model = element.Element("Model")?.Value,
                    Type = element.Element("Type")?.Value,
                    ScreenSize = int.Parse(element.Element("ScreenSize")?.Value ?? "0"),
                    ScreenType = element.Element("ScreenType")?.Value,
                    ScreenResolutionX = int.Parse(element.Element("ScreenResolutionX")?.Value ?? "0"),
                    ScreenResolutionY = int.Parse(element.Element("ScreenResolutionY")?.Value ?? "0"),
                    Touch = element.Element("Touch")?.Value,
                    MatrixType = element.Element("MatrixType")?.Value,
                    RefreshRate = int.Parse(element.Element("RefreshRate")?.Value ?? "0"),
                    Processor = element.Element("Processor")?.Value,
                    ProcessorModel = element.Element("ProcessorModel")?.Value,
                    ProcessorSpeed = element.Element("ProcessorSpeed")?.Value,
                    NumberOfCores = int.Parse(element.Element("NumberOfCores")?.Value ?? "0"),
                    NumberOfThreads = int.Parse(element.Element("NumberOfThreads")?.Value ?? "0"),
                    RAM = int.Parse(element.Element("RAM")?.Value ?? "0"),
                    RAMType = element.Element("RAMType")?.Value,
                    HardDriveType = element.Element("HardDriveType")?.Value,
                    HardDriveCapacity = int.Parse(element.Element("HardDriveCapacity")?.Value ?? "0"),
                    VideoAdapterType = element.Element("VideoAdapterType")?.Value,
                    GPUModel = element.Element("GPUModel")?.Value,
                    VideoMemory = int.Parse(element.Element("VideoMemory")?.Value ?? "0"),
                    Interface = element.Element("Interface")?.Value,
                    OperatingSystem = element.Element("OperatingSystem")?.Value,
                    OpticalDrive = element.Element("OpticalDrive")?.Value,
                    Connectivity = element.Element("Connectivity")?.Value,
                    Weight = element.Element("Weight")?.Value,
                    Color = element.Element("Color")?.Value
                };

                laptops.Add(laptop);
            }

            return laptops;
        }
        public List<ElectronicDevice> TabletLoadXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\Tablet\Tablet.xml";
            List<ElectronicDevice> tablets = new List<ElectronicDevice>();

            XDocument xDocument = XDocument.Load(path);

            foreach (XElement element in xDocument.Descendants("Tablet"))
            {
                Tablet tablet = new Tablet
                {
                    DeviceId = int.Parse(element.Element("DeviceId")?.Value),
                    Brand = element.Element("Brand")?.Value,
                    Model = element.Element("Model")?.Value,
                    ScreenSize = double.Parse(element.Element("ScreenSize")?.Value ?? "0"),
                    ScreenResolutionX = int.Parse(element.Element("ScreenResolutionX")?.Value ?? "0"),
                    ScreenResolutionY = int.Parse(element.Element("ScreenResolutionY")?.Value ?? "0"),
                    PPI = int.Parse(element.Element("PPI")?.Value ?? "0"),
                    PanelType = element.Element("PanelType")?.Value,
                    SIMType = element.Element("SIMType")?.Value,
                    Processor = element.Element("Processor")?.Value,
                    ProcessorSpeed = element.Element("ProcessorSpeed")?.Value,
                    RAM = int.Parse(element.Element("RAM")?.Value ?? "0"),
                    InternalMemory = int.Parse(element.Element("InternalMemory")?.Value ?? "0"),
                    MemoryCardSupport = element.Element("MemoryCardSupport")?.Value,
                    Camera = int.Parse(element.Element("Camera")?.Value ?? "0"),
                    FrontalCamera = int.Parse(element.Element("FrontalCamera")?.Value ?? "0"),
                    Interface = element.Element("Interface")?.Value,
                    TypeOfBattery = element.Element("TypeOfBattery")?.Value,
                    OperatingSystem = element.Element("OperatingSystem")?.Value,
                    Sensors = element.Element("Sensors")?.Value,
                    Communication = element.Element("Communication")?.Value,
                    Size = element.Element("Size")?.Value,
                    Weight = element.Element("Weight")?.Value ?? "0",
                    Color = element.Element("Color")?.Value
                };

                tablets.Add(tablet);
            }

            return tablets;
        }
        public List<ElectronicDevice> PhoneLoadXml()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\Tablet\Phone.xml";
            List<ElectronicDevice> phones = new List<ElectronicDevice>();

            XDocument xDocument = XDocument.Load(path);

            foreach (XElement element in xDocument.Descendants("Phone"))
            {
                Phone phone = new Phone
                {
                    DeviceId = int.Parse(element.Element("DeviceId")?.Value),
                    Brand = element.Element("Brand")?.Value,
                    Model = element.Element("Model")?.Value,
                    ScreenType = element.Element("ScreenType")?.Value,
                    ScreenSize = double.Parse(element.Element("ScreenSize")?.Value ?? "0"),
                    Resolution = element.Element("Resolution")?.Value,
                    UpdateFrequency = int.Parse(element.Element("UpdateFrequency")?.Value ?? "0"),
                    RAMCapacity = int.Parse(element.Element("RAMCapacity")?.Value ?? "0"),
                    InternalMemoryCapacity = int.Parse(element.Element("InternalMemoryCapacity")?.Value ?? "0"),
                    MemoryCardSupport = element.Element("MemoryCardSupport")?.Value,
                    Chipset = element.Element("Chipset")?.Value,
                    GraphicsProcessor = element.Element("GraphicsProcessor")?.Value,
                    Processor = element.Element("Processor")?.Value,
                    OperatingSystem = element.Element("OperatingSystem")?.Value,
                    Video = element.Element("Video")?.Value,
                    Camera = int.Parse(element.Element("Camera")?.Value ?? "0"),
                    AdditionalFeatures = element.Element("AdditionalFeatures")?.Value,
                    SelfieCamera = int.Parse(element.Element("SelfieCamera")?.Value ?? "0"),
                    Type = element.Element("Type")?.Value,
                    ItemVolume = double.Parse(element.Element("ItemVolume")?.Value ?? "0"),
                    ItemType = element.Element("ItemType")?.Value,
                    Ports = element.Element("Ports")?.Value,
                    WiFi = bool.Parse(element.Element("WiFi")?.Value ?? "false"),
                    GPS = bool.Parse(element.Element("GPS")?.Value ?? "false"),
                    NFC = bool.Parse(element.Element("NFC")?.Value ?? "false"),
                    Bluetooth = bool.Parse(element.Element("Bluetooth")?.Value ?? "false"),
                    Technology = element.Element("Technology")?.Value,
                    Sensors = element.Element("Sensors")?.Value,
                    Weight = double.Parse(element.Element("Weight")?.Value ?? "0"),
                    Color = element.Element("Color")?.Value,
                    Size = element.Element("Size")?.Value,
                    BodyMaterial = element.Element("BodyMaterial")?.Value
                };

                phones.Add(phone);
            }

            return phones;
        }

    }
}

