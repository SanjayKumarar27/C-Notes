
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
namespace serilaisation
{
    //[Serializable]

    public class Employee
    {
        [NonSerialized]
        public int id;
        public string name { get; set; }
        public string department { get; set; }
        public double salary { get; set; }

        
    }
    public class AddressDetails
    {
    
        public int houseNo { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //What is serialization?
            //serilaisation is  to  store an object in a file  so that it can be retrieved later.
            //it is also used to send an object over the network.
            //it is also used to store an object in a database.
            // the formats used for serialization are XML, JSON, Binary, SOAP

            //AddressDetails details = new AddressDetails();

            //details.houseNo = 123;
            //details.street = "Main St";
            //details.city = "New York";
            //details.state = "NY";
            //details.zipcode = "10001";
            //XML Serialization
            //XmlSerializer serializer = new XmlSerializer(typeof(AddressDetails));
            //using (TextWriter writer = new StreamWriter("address.xml"))
            //{
            //    serializer.Serialize(writer, details);
            //}


            //what is deserialization?
            //Deserialization is the process of converting a stream of bytes into an object.
            //XML Deserialization
            //XmlSerializer deserializer = new XmlSerializer(typeof(AddressDetails));
            //using (TextReader reader = new StreamReader("address.xml"))
            //{
            //    details = (AddressDetails)deserializer.Deserialize(reader);

            //}
            //Console.WriteLine($"House No: {details.houseNo}");
            //Console.WriteLine($"Street: {details.street}");
            //Console.WriteLine($"City: {details.city}");
            //Console.WriteLine($"State: {details.state}");
            //Console.WriteLine($"Zipcode: {details.zipcode}");

            //Binary Serialization is not supported in .NET Core and later versions.

            //JSON Serialization is Recommended one


            Employee emp = new Employee();
            //emp.id = 101;
            //emp.name = "John Doe";
            //emp.department = "IT";
            //emp.salary = 50000;


            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(emp.GetType());
            //FileStream buffer =File.Create("employee2.json")
            //jsonSerializer.WriteObject(buffer, emp);
            //buffer.Close();
            //Console.WriteLine("JSON Serialization Completed");

            //JSON Deserialization
            FileStream buffer = File.OpenRead("employee.json");
            emp = (Employee)jsonSerializer.ReadObject(buffer);
            buffer.Close();
            Console.WriteLine($"ID: {emp.id}");
            Console.WriteLine($"Name: {emp.name}");
            Console.WriteLine($"Department: {emp.department}");
            Console.WriteLine($"Salary: {emp.salary}");
            Console.WriteLine("JSON Deserialization Completed");




        }
    }
}
