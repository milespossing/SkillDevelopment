using System.Collections.Generic;

namespace entityFrameworkTest_ConsoleApp.Models
{
    public class PersonAddress : ModelBase
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public virtual ICollection<Person> People { get; set; }

        public PersonAddress() { }
        public PersonAddress(string street, string city, string state, int zipCode) : this()
        {
            Line1 = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
}