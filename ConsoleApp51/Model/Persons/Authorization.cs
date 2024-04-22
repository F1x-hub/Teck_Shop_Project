using ConsoleApp51.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp51.Model.Persons
{
    internal class Authorization
    {
        AddProduct product = new AddProduct();
        AddXmlFile addXmlFile = new AddXmlFile();
        LoadXmlFile loadXmlFile = new LoadXmlFile();
        AddProduct AddProduct = new AddProduct();
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\Person\registered_users.xml";
        public object Authorizations(List<Person> people)
        {
            string controler = "0";
            object person = null;
            while (controler != "4")
            {
                Console.WriteLine("1. LogIn\n2. Registration\n3. Stay Guest\n4. Exit");
                controler = Console.ReadLine();

                if (controler == "1")
                {
                    person = LogIn(people);
                    return person;
                }
                if (controler == "2")
                {
                    Registration(people);
                }
                if (controler == "3")
                {

                }
            }
            return person;
            
        }
        public void Registration(List<Person> people)
        {
            AddProduct.AddPerson(people);
        }
        public dynamic LogIn(List<Person> people) 
        {
            string rootFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Store", "model", "Person", "registered_users");


            if (!Directory.Exists(rootFolderPath))
            {
                Registration(people);
            }
            string controler = "0";
            User findUser = null;
            Admin findAdmin = null;
            while(controler != "3")
            {
                Console.WriteLine("1. User\n2. Admin\n3. Exit");
                controler = Console.ReadLine();
                if (controler == "1") 
                {
                    findUser = LogInUser(people);
                    return findUser;
                }
                if(controler == "2") 
                {
                    findAdmin = LogInAdmin(people);
                    return findAdmin; 
                }
                
            }
            return default;
        }
        public Admin LogInAdmin(List<Person> people)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Store\model\Person\registered_admins.xml";
            if (File.Exists(path))
            {
                loadXmlFile.AdminLoadXml(path);
                people.AddRange(loadXmlFile.AdminLoadXml(path));
            }
            else
            {
                Console.WriteLine("Admin information XML file does not exist. Skipping loading.");
            }


            Console.WriteLine("Admin LogIn\n");

            Console.Write("Enter UserName: ");
            string userName = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            
            foreach (Admin person in people)
            {
                if (person.UserName == userName && person.Password == password)
                {
                    Console.WriteLine("Succesful");
                    return person;
                }
                else
                {
                    Console.WriteLine("Admin not Found");
                    break;
                }
            }
            return null;
        }
        public User LogInUser(List<Person> people) 
        {
            Console.WriteLine("User LogIn\n");

            Console.Write("Enter UserName: ");
            string userName = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            string userXmlFilePath = GetUserXmlFilePath(userName);

            
            if (File.Exists(userXmlFilePath))
            {
                
                
                people.AddRange(loadXmlFile.UserLoadXml(userXmlFilePath));

                foreach (Person person in people)
                {
                    if (person is User user)
                    {
                        if (user != null && user.Password == password)
                        {
                            Console.WriteLine("Login successful");
                            return user;
                        }
                    }
                    else
                    {
                        Console.WriteLine("User not found or incorrect password.");
                    }
                }

                
            }
            else
            {
                Console.WriteLine("User XML file not found.");
            }

            return null;
            
        }
        public string Validation(object obj)
        {
            
            var validationContext = new ValidationContext(obj, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(obj, validationContext, validationResults, validateAllProperties: true);

            if (!isValid)
            {
                string errorMessage = string.Join("\n", validationResults.Select(vr => vr.ErrorMessage));
                return errorMessage;
            }
            else
            {
                return "successful";
            }
        }
        public string GetUserXmlFilePath(string userName)
        {
            string rootFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Store", "model", "Person", "registered_users");

            string userFolderPath = Path.Combine(rootFolderPath, userName);

            string userXmlFilePath = Path.Combine(userFolderPath, $"{userName}.xml");

            return userXmlFilePath;
        }
        public string GetUserFolderPath(string userName)
        {
            string rootFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Store", "model", "Person", "registered_users");

            string userFolderPath = Path.Combine(rootFolderPath, userName);

            return userFolderPath;
        }
    }
}
