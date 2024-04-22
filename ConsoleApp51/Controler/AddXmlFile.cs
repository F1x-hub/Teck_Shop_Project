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
using System.Xml.Linq;

namespace ConsoleApp51
{
    internal class AddXmlFile
    {
        AddProduct product = new AddProduct();
        
        public void CreateFolders()
        {
            string rootFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Store");
            string modelFolder = Path.Combine(rootFolder, "model");
            string[] subFolders = { "Computer", "ComputerParts", "Tablet", "Person" };

            
            if (!Directory.Exists(rootFolder))
            {
                Directory.CreateDirectory(rootFolder);
                Console.WriteLine("Root folder 'store' created.");
            }

            
            if (!Directory.Exists(modelFolder))
            {
                Directory.CreateDirectory(modelFolder);
                Console.WriteLine("Model folder created.");
            }


            foreach (var folder in subFolders)
            {
                string subFolderPath = Path.Combine(modelFolder, folder);
                if (!Directory.Exists(subFolderPath))
                {
                    Directory.CreateDirectory(subFolderPath);
                    Console.WriteLine($"Subfolder '{folder}' created.");

                    
                    if (folder == "Computer")
                    {
                        CreateXmlFileIfNotExists(subFolderPath, "Computer.xml", "Computers");
                        CreateXmlFileIfNotExists(subFolderPath, "AllInOneComputer.xml", "Computers");
                        CreateXmlFileIfNotExists(subFolderPath, "Consoles.xml", "Consoles");
                    }
                    else if (folder == "ComputerParts")
                    {
                        CreateXmlFileIfNotExists(subFolderPath, "Case.xml", "Cases");
                        CreateXmlFileIfNotExists(subFolderPath, "Cooler.xml", "Coolers");
                        CreateXmlFileIfNotExists(subFolderPath, "CPU.xml", "CPUs");
                        CreateXmlFileIfNotExists(subFolderPath, "GPU.xml", "GPUs");
                        CreateXmlFileIfNotExists(subFolderPath, "HardDrive.xml", "HardDrives");
                        CreateXmlFileIfNotExists(subFolderPath, "Motherboard.xml", "Motherboards");
                        CreateXmlFileIfNotExists(subFolderPath, "PowerSupply.xml", "PowerSupplies");
                        CreateXmlFileIfNotExists(subFolderPath, "RAM.xml", "RAMs");
                    }
                    else if (folder == "Tablet")
                    {
                        CreateXmlFileIfNotExists(subFolderPath, "Laptop.xml", "Laptops");
                        CreateXmlFileIfNotExists(subFolderPath, "Phone.xml", "Phones");
                        CreateXmlFileIfNotExists(subFolderPath, "Tablet.xml", "Tablets");
                    }
                    
                }
            }
        }
        private void CreateXmlFileIfNotExists(string folderPath, string fileName, string rootElementName)
        {
            string filePath = Path.Combine(folderPath, fileName);
            if (!File.Exists(filePath))
            {
                XDocument xDocument = new XDocument();
                xDocument.Add(new XElement(rootElementName)); 
                xDocument.Save(filePath);
                Console.WriteLine($"XML file '{fileName}' created in '{folderPath}' with root element '{rootElementName}'.");
            }
            else
            {
                Console.WriteLine($"XML file '{fileName}' already exists in '{folderPath}'.");
            }
        }

        public void ComputerAddXml(List<ElectronicDevice> electronicDevices)
        {

            
            product.AddComputer(electronicDevices);
            
            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\Computer\Computer.xml";

            XDocument xDocument;
            if (File.Exists(path))
            {
                xDocument = XDocument.Load(path);
            }
            else
            {

                xDocument = new XDocument();
                xDocument.Add(new XElement("Computers"));
            }
            XElement computersElement = xDocument.Root;
            

            
            foreach (ElectronicDevice device in electronicDevices)
            {
                if (device is Computer computer)
                {
                    
                    XElement computerElement = new XElement("Computer",
                        new XElement("DeviceId", computer.DeviceId = 2),
                        new XElement("Brand", computer.Brand),
                        new XElement("Model", computer.Model),
                        new XElement("ProcessorManufacturer", computer.ProcessorManufacturer),
                        new XElement("TypeOfProcessor", computer.TypeOfProcessor),
                        new XElement("ModelOfProcessor", computer.ModelOfProcessor),
                        new XElement("Cores", computer.Cores),
                        new XElement("Thread", computer.Thread),
                        new XElement("CPUFrequency", computer.CPUFrequency),
                        new XElement("RAM", computer.RAM),
                        new XElement("TypeOfRAMMemory", computer.TypeOfRAMMemory),
                        new XElement("RAMMemorySpeed", computer.RAMMemorySpeed),
                        new XElement("HardDriveSSD", computer.HardDriveSSD),
                        new XElement("SSDInterface", computer.SSDInterface),
                        new XElement("TypeOfVideoAdapter", computer.TypeOfVideoAdapter),
                        new XElement("GraphicController", computer.GraphicController),
                        new XElement("Interface", computer.Interface),
                        new XElement("OperatingSystem", computer.OperatingSystem),
                        new XElement("Connectivity", computer.Connectivity),
                        new XElement("Dimensions", computer.Dimensions),
                        new XElement("Weight", computer.Weight),
                        new XElement("Color", computer.Color),
                        new XElement("IncludedAccessories", computer.IncludedAccessories),
                        new XElement("Price", computer.Price) 
                    );

                    
                    computersElement.Add(computerElement);
                }
            }

            
            

            try
            {
                
                xDocument.Save(path);
                Console.WriteLine("XML file saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving XML file: {ex.Message}");
            }
        }
        public void ConsolesAddXml(List<ElectronicDevice> electronicDevices)
        {
            
            product.AddConsoles(electronicDevices);

            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\Computer\Consoles.xml";

            XDocument xDocument;
            if (File.Exists(path))
            {
                xDocument = XDocument.Load(path);
            }
            else
            {

                xDocument = new XDocument();
                xDocument.Add(new XElement("Consoles"));
            }
            XElement consolesElement = xDocument.Root;
            

            
            foreach (ElectronicDevice device in electronicDevices)
            {
                if (device is Consoles console)
                {
                    
                    XElement consoleElement = new XElement("Console",
                        new XElement("DeviceId", console.DeviceId = 3),
                        new XElement("Brand", console.Brand),
                        new XElement("Model", console.Model),
                        new XElement("TypeOfChipset", console.TypeOfChipset),
                        new XElement("NumberOfCores", console.NumberOfCores),
                        new XElement("RAM", console.RAM),
                        new XElement("TypeOfRAMMemory", console.TypeOfRAMMemory),
                        new XElement("GraphicController", console.GraphicController),
                        new XElement("TypeOfMemory", console.TypeOfMemory),
                        new XElement("Interface", console.Interface),
                        new XElement("OpticalDrive", console.OpticalDrive),
                        new XElement("Connectivity", console.Connectivity),
                        new XElement("Dimensions", console.Dimensions),
                        new XElement("Weight", console.Weight),
                        new XElement("Color", console.Color),
                        new XElement("Price", console.Price)
                    );

                    
                    consolesElement.Add(consoleElement);
                }
            }

            
            

            try
            {
                
                xDocument.Save(path);
                Console.WriteLine("XML file saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving XML file: {ex.Message}");
            }
        }
        public void AllInOneComputerAddXml(List<ElectronicDevice> electronicDevices)
        {
            
            product.AddAllInOneComputer(electronicDevices);

           
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\Computer\AllInOneComputer.xml";


            
            XDocument xDocument;
            if (File.Exists(path))
            {
                xDocument = XDocument.Load(path);
            }
            else
            {
                
                xDocument = new XDocument();
                xDocument.Add(new XElement("AllInOneComputers"));
            }
            XElement allInOneComputersElement = xDocument.Root;

            foreach (ElectronicDevice device in electronicDevices)
            {
                if (device is AllInOneComputer allInOneComputer)
                {
                    
                    XElement allInOneComputerElement = new XElement("AllInOneComputer",
                        new XElement("DeviceId", allInOneComputer.DeviceId = 1),
                        new XElement("Brand", allInOneComputer.Brand),
                        new XElement("Model", allInOneComputer.Model),
                        new XElement("ScreenSize", allInOneComputer.ScreenSize),
                        new XElement("ScreenType", allInOneComputer.ScreenType),
                        new XElement("ScreenResolutionWidth", allInOneComputer.ScreenResolutionWidth),
                        new XElement("ScreenResolutionHeight", allInOneComputer.ScreenResolutionHeight),
                        new XElement("TouchScreen", allInOneComputer.TouchScreen),
                        new XElement("MatrixType", allInOneComputer.MatrixType),
                        new XElement("ProcessorManufacturer", allInOneComputer.ProcessorManufacturer),
                        new XElement("TypeOfProcessor", allInOneComputer.TypeOfProcessor),
                        new XElement("ModelOfProcessor", allInOneComputer.ModelOfProcessor),
                        new XElement("Cores", allInOneComputer.Cores),
                        new XElement("Thread", allInOneComputer.Thread),
                        new XElement("CPUFrequency", allInOneComputer.CPUFrequency),
                        new XElement("RAM", allInOneComputer.RAM),
                        new XElement("TypeOfRAMMemory", allInOneComputer.TypeOfRAMMemory),
                        new XElement("RAMMemorySpeed", allInOneComputer.RAMMemorySpeed),
                        new XElement("HardDriveSSD", allInOneComputer.HardDriveSSD),
                        new XElement("SSDInterface", allInOneComputer.SSDInterface),
                        new XElement("TypeOfVideoAdapter", allInOneComputer.TypeOfVideoAdapter),
                        new XElement("GraphicController", allInOneComputer.GraphicController),
                        new XElement("Interface", allInOneComputer.Interface),
                        new XElement("OperatingSystem", allInOneComputer.OperatingSystem),
                        new XElement("Connectivity", allInOneComputer.Connectivity),
                        new XElement("Dimensions", allInOneComputer.Dimensions),
                        new XElement("Weight", allInOneComputer.Weight),
                        new XElement("Color", allInOneComputer.Color),
                        new XElement("IncludedAccessories", allInOneComputer.IncludedAccessories),
                        new XElement("Price", allInOneComputer.Price)
                    );

                    
                    allInOneComputersElement.Add(allInOneComputerElement);
                }
            }

            
            

            try
            {
                
                xDocument.Save(path);
                Console.WriteLine("XML file saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving XML file: {ex.Message}");
            }
        }
        public void CaseAddXml(List<ElectronicDevice> electronicDevices)
        {
            
            product.AddCase(electronicDevices);

            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\ComputerParts\Case.xml";

            XDocument xDocument;
            if (File.Exists(path))
            {
                xDocument = XDocument.Load(path);
            }
            else
            {

                xDocument = new XDocument();
                xDocument.Add(new XElement("Cases"));
            }
            XElement casesElement = xDocument.Root;
            

            
            foreach (ElectronicDevice device in electronicDevices)
            {
                if (device is Case computerCase)
                {
                    
                    XElement caseElement = new XElement("Case",
                        new XElement("DeviceId", computerCase.DeviceId = 1),
                        new XElement("Brand", computerCase.Brand),
                        new XElement("Model", computerCase.Model),
                        new XElement("CaseType", computerCase.CaseType),
                        new XElement("MotherboardFormFactor", computerCase.MotherboardFormFactor),
                        new XElement("Cooling", computerCase.Cooling),
                        new XElement("InterfaceButtons", computerCase.InterfaceButtons),
                        new XElement("LiquidCoolingCompatibility", computerCase.LiquidCoolingCompatibility),
                        new XElement("Dimensions", computerCase.Dimensions),
                        new XElement("Weight", computerCase.Weight),
                        new XElement("Color", computerCase.Color),
                        new XElement("Price", computerCase.Price)
                    );

                    
                    casesElement.Add(caseElement);
                }
            }

            
            

            try
            {
                
                xDocument.Save(path);
                Console.WriteLine("XML file saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving XML file: {ex.Message}");
            }
        }
        public void CoolerAddXml(List<ElectronicDevice> electronicDevices)
        {
            
            product.AddCooler(electronicDevices);

            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\ComputerParts\Cooler.xml";

            XDocument xDocument;
            if (File.Exists(path))
            {
                xDocument = XDocument.Load(path);
            }
            else
            {

                xDocument = new XDocument();
                xDocument.Add(new XElement("Coolers"));
            }
            XElement coolersElement = xDocument.Root;
            

            
            foreach (ElectronicDevice device in electronicDevices)
            {
                if (device is Cooler cooler)
                {
                    
                    XElement coolerElement = new XElement("Cooler",
                        new XElement("DeviceId", cooler.DeviceId = 2),
                        new XElement("Destination", cooler.Destination),
                        new XElement("SocketCompatibility", cooler.SocketCompatibility),
                        new XElement("NumberOfFan", cooler.NumberOfFan),
                        new XElement("RotationalSpeed", cooler.RotationalSpeed),
                        new XElement("FanDimensions", cooler.FanDimensions),
                        new XElement("FanNoiseLevel", cooler.FanNoiseLevel),
                        new XElement("Lighting", cooler.Lighting),
                        new XElement("Price", cooler.Price)
                    );

                   
                    coolersElement.Add(coolerElement);
                }
            }

            
           

            try
            {
                
                xDocument.Save(path);
                Console.WriteLine("XML file saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving XML file: {ex.Message}");
            }
        }
        public void CPUAddXml(List<ElectronicDevice> electronicDevices)
        {
            
            product.AddCPU(electronicDevices);

            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\ComputerParts\CPU.xml";

            XDocument xDocument;
            if (File.Exists(path))
            {
                xDocument = XDocument.Load(path);
            }
            else
            {

                xDocument = new XDocument();
                xDocument.Add(new XElement("CPUs"));
            }
            XElement cpusElement = xDocument.Root;
            

            
            foreach (ElectronicDevice device in electronicDevices)
            {
                if (device is CPU cpu)
                {
                    
                    XElement cpuElement = new XElement("CPU",
                        new XElement("DeviceId", cpu.DeviceId = 3),
                        new XElement("Processor", cpu.Processor),
                        new XElement("ModelName", cpu.ModelName),
                        new XElement("ProcessorSpeed", cpu.ProcessorSpeed),
                        new XElement("MaxProcessorSpeed", cpu.MaxProcessorSpeed),
                        new XElement("Cores", cpu.Cores),
                        new XElement("Thread", cpu.Thread),
                        new XElement("Cache", cpu.Cache),
                        new XElement("MemoryTypes", cpu.MemoryTypes),
                        new XElement("MaxMemorySize", cpu.MaxMemorySize),
                        new XElement("IntegratedGraphicCard", cpu.IntegratedGraphicCard),
                        new XElement("GraphicCardModel", cpu.GraphicCardModel),
                        new XElement("Socket", cpu.Socket),
                        new XElement("PCIExpressVersion", cpu.PCIExpressVersion),
                        new XElement("TDP", cpu.TDP),
                        new XElement("Price", cpu.Price)
                    );

                    
                    cpusElement.Add(cpuElement);
                }
            }

            
            

            try
            {
                
                xDocument.Save(path);
                Console.WriteLine("XML file saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving XML file: {ex.Message}");
            }
        }
        public void GPUAddXml(List<ElectronicDevice> electronicDevices)
        {
            
            product.AddGPU(electronicDevices);

            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\ComputerParts\GPU.xml";

            XDocument xDocument;
            if (File.Exists(path))
            {
                xDocument = XDocument.Load(path);
            }
            else
            {

                xDocument = new XDocument();
                xDocument.Add(new XElement("GPUs"));
            }
            XElement gpusElement = xDocument.Root;
            

            
            foreach (ElectronicDevice device in electronicDevices)
            {
                if (device is GPU gpu)
                {
                    
                    XElement gpuElement = new XElement("GPU",
                        new XElement("DeviceId", gpu.DeviceId = 4),
                        new XElement("GraphicEngine", gpu.GraphicEngine),
                        new XElement("GraphicEngineModel", gpu.GraphicEngineModel),
                        new XElement("GPUClock", gpu.GPUClock),
                        new XElement("BoostClock", gpu.BoostClock),
                        new XElement("MemoryType", gpu.MemoryType),
                        new XElement("Memory", gpu.Memory),
                        new XElement("MemoryInterfaceWidth", gpu.MemoryInterfaceWidth),
                        new XElement("CoolingSystem", gpu.CoolingSystem),
                        new XElement("Interface", gpu.Interface),
                        new XElement("VideoCardInterface", gpu.VideoCardInterface),
                        new XElement("Dimensions", gpu.Dimensions),
                        new XElement("Price", gpu.Price)
                    );

                    
                    gpusElement.Add(gpuElement);
                }
            }

            
            

            try
            {
                
                xDocument.Save(path);
                Console.WriteLine("XML file saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving XML file: {ex.Message}");
            }
        }
        public void HardDriveAddXml(List<ElectronicDevice> electronicDevices)
        {
            
            product.AddHardDrive(electronicDevices);

            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\ComputerParts\HardDrive.xml";

            XDocument xDocument;
            if (File.Exists(path))
            {
                xDocument = XDocument.Load(path);
            }
            else
            {

                xDocument = new XDocument();
                xDocument.Add(new XElement("HardDrives"));
            }
            XElement hardDrivesElement = xDocument.Root;
            

            
            foreach (ElectronicDevice device in electronicDevices)
            {
                if (device is HardDrive hardDrive)
                {
                    
                    XElement hardDriveElement = new XElement("HardDrive",
                        new XElement("DeviceId", hardDrive.DeviceId = 5),
                        new XElement("Type", hardDrive.Type),
                        new XElement("FormFactor", hardDrive.FormFactor),
                        new XElement("StorageCapacity", hardDrive.StorageCapacity),
                        new XElement("HardDriveType", hardDrive.HardDriveType),
                        new XElement("PCle", hardDrive.PCle),
                        new XElement("Dimensions", hardDrive.Dimensions),
                        new XElement("Weight", hardDrive.Weight)
                    );

                    
                    hardDrivesElement.Add(hardDriveElement);
                }
            }

            
           

            try
            {
                
                xDocument.Save(path);
                Console.WriteLine("XML file saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving XML file: {ex.Message}");
            }
        }
        public void MotherboardAddXml(List<ElectronicDevice> electronicDevices)
        {
            
            product.AddMotherboard(electronicDevices);

            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\ComputerParts\Motherboard.xml";

            XDocument xDocument;
            if (File.Exists(path))
            {
                xDocument = XDocument.Load(path);
            }
            else
            {

                xDocument = new XDocument();
                xDocument.Add(new XElement("Motherboards"));
            }
            XElement motherboardsElement = xDocument.Root;
            

            
            foreach (ElectronicDevice device in electronicDevices)
            {
                if (device is Motherboard motherboard)
                {
                    
                    XElement motherboardElement = new XElement("Motherboard",
                        new XElement("DeviceId", motherboard.DeviceId = 6),
                        new XElement("ModelName", motherboard.ModelName),
                        new XElement("FormFactor", motherboard.FormFactor),
                        new XElement("Socket", motherboard.Socket),
                        new XElement("Chipset", motherboard.Chipset),
                        new XElement("CompatibilityProcessors", motherboard.CompatibilityProcessors),
                        new XElement("MaxMemory", motherboard.MaxMemory),
                        new XElement("MemoryType", motherboard.MemoryType),
                        new XElement("MaxMemoryMHz", motherboard.MaxMemoryMHz),
                        new XElement("NumberOfMemorySlots", motherboard.NumberOfMemorySlots),
                        new XElement("MemorySlotsType", motherboard.MemorySlotsType),
                        new XElement("VersionOfPCIExpress", motherboard.VersionOfPCIExpress),
                        new XElement("IncludedAccessories", motherboard.IncludedAccessories),
                        new XElement("OperatingSystem", motherboard.OperatingSystem),
                        new XElement("DimensionsWidth", motherboard.DimensionsWidth),
                        new XElement("DimensionsHeight", motherboard.DimensionsHeight)
                    );

                    
                    motherboardsElement.Add(motherboardElement);
                }
            }

            
            

            try
            {
                
                xDocument.Save(path);
                Console.WriteLine("XML file saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving XML file: {ex.Message}");
            }
        }
        public void PowerSupplyAddXml(List<ElectronicDevice> electronicDevices)
        {
            
            product.AddPowerSupply(electronicDevices);

            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\ComputerParts\powersupplies.xml";

            XDocument xDocument;
            if (File.Exists(path))
            {
                xDocument = XDocument.Load(path);
            }
            else
            {

                xDocument = new XDocument();
                xDocument.Add(new XElement("PowerSupplies"));
            }
            XElement powerSuppliesElement = xDocument.Root;
            

           
            foreach (ElectronicDevice device in electronicDevices)
            {
                if (device is PowerSupply powerSupply)
                {
                    
                    XElement powerSupplyElement = new XElement("PowerSupply",
                        new XElement("DeviceId", powerSupply.DeviceId = 7),
                        new XElement("FormFactor", powerSupply.FormFactor),
                        new XElement("Watts", powerSupply.Watts),
                        new XElement("InputVoltage", powerSupply.InputVoltage),
                        new XElement("InputFrequencyRange", powerSupply.InputFrequencyRange),
                        new XElement("PowerConnectorsCPU", powerSupply.PowerConnectorsCPU),
                        new XElement("PFC", powerSupply.PFC)
                    );

                    
                    powerSuppliesElement.Add(powerSupplyElement);
                }
            }

            
            

            try
            {
                
                xDocument.Save(path);
                Console.WriteLine("XML file saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving XML file: {ex.Message}");
            }
        }
        public void RAMAddXml(List<ElectronicDevice> electronicDevices)
        {
            
            product.AddRAM(electronicDevices);

            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\ComputerParts\ram.xml";

            XDocument xDocument;
            if (File.Exists(path))
            {
                xDocument = XDocument.Load(path);
            }
            else
            {

                xDocument = new XDocument();
                xDocument.Add(new XElement("RAM"));
            }
            XElement ramElement = xDocument.Root;
            

            
            foreach (ElectronicDevice device in electronicDevices)
            {
                if (device is RAM ram)
                {
                    
                    XElement ramDetailElement = new XElement("RAM",
                        new XElement("DeviceId", ram.DeviceId = 8),
                        new XElement("Compatibility", ram.Compatibility),
                        new XElement("FormFactor", ram.FormFactor),
                        new XElement("Volume", ram.Volume),
                        new XElement("MemoryType", ram.MemoryType),
                        new XElement("MemoryClock", ram.MemoryClock),
                        new XElement("Radiator", ram.Radiator)
                    );

                    
                    ramElement.Add(ramDetailElement);
                }
            }

            
            

            try
            {
                
                xDocument.Save(path);
                Console.WriteLine("XML file saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving XML file: {ex.Message}");
            }
        }
        public void LaptopAddXml(List<ElectronicDevice> electronicDevices)
        {
            product.AddLaptop(electronicDevices);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\Tablet\laptop.xml";

            XDocument xDocument;
            if (File.Exists(path))
            {
                xDocument = XDocument.Load(path);
            }
            else
            {

                xDocument = new XDocument();
                xDocument.Add(new XElement("Laptops"));
            }
            XElement laptopsElement = xDocument.Root;
            

            foreach (ElectronicDevice device in electronicDevices)
            {
                if (device is Laptop laptop)
                {
                    XElement laptopElement = new XElement("Laptop",
                        new XElement("DeviceId", laptop.DeviceId = 1),
                        new XElement("Brand", laptop.Brand),
                        new XElement("Model", laptop.Model),
                        new XElement("Type", laptop.Type),
                        new XElement("ScreenSize", laptop.ScreenSize),
                        new XElement("ScreenType", laptop.ScreenType),
                        new XElement("ScreenResolutionX", laptop.ScreenResolutionX),
                        new XElement("ScreenResolutionY", laptop.ScreenResolutionY),
                        new XElement("Touch", laptop.Touch),
                        new XElement("MatrixType", laptop.MatrixType),
                        new XElement("RefreshRate", laptop.RefreshRate),
                        new XElement("Processor", laptop.Processor),
                        new XElement("ProcessorModel", laptop.ProcessorModel),
                        new XElement("ProcessorSpeed", laptop.ProcessorSpeed),
                        new XElement("NumberOfCores", laptop.NumberOfCores),
                        new XElement("NumberOfThreads", laptop.NumberOfThreads),
                        new XElement("RAM", laptop.RAM),
                        new XElement("RAMType", laptop.RAMType),
                        new XElement("HardDriveType", laptop.HardDriveType),
                        new XElement("HardDriveCapacity", laptop.HardDriveCapacity),
                        new XElement("VideoAdapterType", laptop.VideoAdapterType),
                        new XElement("GPUModel", laptop.GPUModel),
                        new XElement("VideoMemory", laptop.VideoMemory),
                        new XElement("Interface", laptop.Interface),
                        new XElement("OperatingSystem", laptop.OperatingSystem),
                        new XElement("OpticalDrive", laptop.OpticalDrive),
                        new XElement("Connectivity", laptop.Connectivity),
                        new XElement("Weight", laptop.Weight),
                        new XElement("Color", laptop.Color)
                    );

                    laptopsElement.Add(laptopElement);
                }
            }

            

            try
            {
                xDocument.Save(path);
                Console.WriteLine("XML file saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving XML file: {ex.Message}");
            }
        }
        public void TabletAddXml(List<ElectronicDevice> electronicDevices)
        {
            product.AddTablet(electronicDevices);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\Tablet\tablet.xml";

            XDocument xDocument;
            if (File.Exists(path))
            {
                xDocument = XDocument.Load(path);
            }
            else
            {

                xDocument = new XDocument();
                xDocument.Add(new XElement("Tablets"));
            }
            XElement tabletsElement = xDocument.Root;
            

            foreach (ElectronicDevice device in electronicDevices)
            {
                if (device is Tablet tablet)
                {
                    XElement tabletElement = new XElement("Tablet",
                        new XElement("DeviceId", tablet.DeviceId = 3),
                        new XElement("Brand", tablet.Brand),
                        new XElement("Model", tablet.Model),
                        new XElement("ScreenSize", tablet.ScreenSize),
                        new XElement("ScreenResolutionX", tablet.ScreenResolutionX),
                        new XElement("ScreenResolutionY", tablet.ScreenResolutionY),
                        new XElement("PPI", tablet.PPI),
                        new XElement("PanelType", tablet.PanelType),
                        new XElement("SIMType", tablet.SIMType),
                        new XElement("Processor", tablet.Processor),
                        new XElement("ProcessorSpeed", tablet.ProcessorSpeed),
                        new XElement("RAM", tablet.RAM),
                        new XElement("InternalMemory", tablet.InternalMemory),
                        new XElement("MemoryCardSupport", tablet.MemoryCardSupport),
                        new XElement("Camera", tablet.Camera),
                        new XElement("FrontalCamera", tablet.FrontalCamera),
                        new XElement("Interface", tablet.Interface),
                        new XElement("TypeOfBattery", tablet.TypeOfBattery),
                        new XElement("OperatingSystem", tablet.OperatingSystem),
                        new XElement("Sensors", tablet.Sensors),
                        new XElement("Communication", tablet.Communication),
                        new XElement("Size", tablet.Size),
                        new XElement("Weight", tablet.Weight),
                        new XElement("Color", tablet.Color)
                    );

                    tabletsElement.Add(tabletElement);
                }
            }

            

            try
            {
                xDocument.Save(path);
                Console.WriteLine("XML file saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving XML file: {ex.Message}");
            }
        }
        public void PhoneAddXml(List<ElectronicDevice> electronicDevices)
        {
            product.AddPhone(electronicDevices);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\Tablet\phone.xml";

            XDocument xDocument;
            if (File.Exists(path))
            {
                xDocument = XDocument.Load(path);
            }
            else
            {

                xDocument = new XDocument();
                xDocument.Add(new XElement("Phones"));
            }
            XElement phonesElement = xDocument.Root;
            

            foreach (ElectronicDevice device in electronicDevices)
            {
                if (device is Phone phone)
                {
                    XElement phoneElement = new XElement("Phone",
                        new XElement("DeviceId", phone.DeviceId = 2),
                        new XElement("Brand", phone.Brand),
                        new XElement("Model", phone.Model),
                        new XElement("ScreenType", phone.ScreenType),
                        new XElement("ScreenSize", phone.ScreenSize),
                        new XElement("Resolution", phone.Resolution),
                        new XElement("UpdateFrequency", phone.UpdateFrequency),
                        new XElement("RAMCapacity", phone.RAMCapacity),
                        new XElement("InternalMemoryCapacity", phone.InternalMemoryCapacity),
                        new XElement("MemoryCardSupport", phone.MemoryCardSupport),
                        new XElement("Chipset", phone.Chipset),
                        new XElement("GraphicsProcessor", phone.GraphicsProcessor),
                        new XElement("Processor", phone.Processor),
                        new XElement("OperatingSystem", phone.OperatingSystem),
                        new XElement("Video", phone.Video),
                        new XElement("Camera", phone.Camera),
                        new XElement("AdditionalFeatures", phone.AdditionalFeatures),
                        new XElement("SelfieCamera", phone.SelfieCamera),
                        new XElement("Type", phone.Type),
                        new XElement("ItemVolume", phone.ItemVolume),
                        new XElement("ItemType", phone.ItemType),
                        new XElement("Ports", phone.Ports),
                        new XElement("WiFi", phone.WiFi),
                        new XElement("GPS", phone.GPS),
                        new XElement("NFC", phone.NFC),
                        new XElement("Bluetooth", phone.Bluetooth),
                        new XElement("Technology", phone.Technology),
                        new XElement("Sensors", phone.Sensors),
                        new XElement("Weight", phone.Weight),
                        new XElement("Color", phone.Color),
                        new XElement("Size", phone.Size),
                        new XElement("BodyMaterial", phone.BodyMaterial)
                    );

                    phonesElement.Add(phoneElement);
                }
            }

            

            try
            {
                xDocument.Save(path);
                Console.WriteLine("XML file saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving XML file: {ex.Message}");
            }
        }
        public void UserAddXml(List<Person> peoples)
        {

            string rootFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ @"\Store\model\Person\registered_users");

            
            if (!Directory.Exists(rootFolderPath))
            {
                Directory.CreateDirectory(rootFolderPath);
                Console.WriteLine("Root folder 'registered_users' created.");
            }

            foreach (Person people in peoples)
            {
                if (people is User user)
                {
                    string userFolderPath = Path.Combine(rootFolderPath, user.UserName);

                    
                    if (!Directory.Exists(userFolderPath))
                    {
                        Directory.CreateDirectory(userFolderPath);
                        Console.WriteLine($"User folder '{user.UserName}' created.");
                    }

                    string userXmlFilePath = Path.Combine(userFolderPath, $"{user.UserName}.xml");

                    
                    XDocument xDocument = new XDocument(
                        new XElement("User",
                            new XElement("UserName", user.UserName),
                            new XElement("Password", user.Password),
                            new XElement("FirstName", user.FirstName),
                            new XElement("LastName", user.LastName),
                            new XElement("Age", user.Age),
                            new XElement("Mail", user.Mail)
                        )
                    );

                    try
                    {
                        xDocument.Save(userXmlFilePath);
                        Console.WriteLine($"User information for '{user.UserName}' saved to XML file successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error saving user information for '{user.UserName}' to XML file: {ex.Message}");
                    }
                }
            }
        }
        public void AdminAddXml(List<Person> peoples)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\Person\registered_admins.xml";

            XDocument xDocument;
            if (File.Exists(path))
            {
                xDocument = XDocument.Load(path);
            }
            else
            {
                xDocument = new XDocument();
                xDocument.Add(new XElement("Admins"));


            }

            XElement usersElement = xDocument.Root;

            foreach (Admin people in peoples)
            {
                if (people is Admin admin)
                {
                    XElement userElement = new XElement("Admin",
                        new XElement("UserName", admin.UserName),
                        new XElement("Password", admin.Password),
                        new XElement("FirstName", admin.FirstName),
                        new XElement("LastName", admin.LastName),
                        new XElement("Age", admin.Age),
                        new XElement("Mail", admin.Mail)
                    );

                    usersElement.Add(userElement);
                }
            }

            try
            {
                xDocument.Save(path);
                Console.WriteLine("Admin information saved to XML file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving admin information to XML file: {ex.Message}");
            }
        }
    }
}
