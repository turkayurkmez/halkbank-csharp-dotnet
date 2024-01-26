using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }

    public class CustomerService
    {
        public List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                 new(){ Id=1, Name="Türkay", Address="Odunpazarı", Country="Türkiye",  City ="Eskişehir"},
                 new(){ Id=2, Name="Zeynep", Address="Pendik", Country="Türkiye",  City ="İstanbul"},
                 new(){ Id=3, Name="Burcu", Address="Dam Square", Country="Hollanda",  City ="Amsterdam"},

            };
        }
    }
}
