// See https://aka.ms/new-console-template for more information
using Serialization;
using System.Text.Json;
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");
var customers = new CustomerService().GetCustomers();

string jsonString = JsonSerializer.Serialize(customers);
//File.WriteAllText("customers.json", jsonString);

var deserialized = JsonSerializer.Deserialize<List<Customer>>(File.ReadAllText("customers.json"));
deserialized.ForEach(customer => Console.WriteLine($"{customer.Name} {customer.City} {customer.Country}"));

XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer>));
xmlSerializer.Serialize(new FileStream("customers.xml", FileMode.CreateNew), customers);
