using System;

namespace entityFrameworkTest_ConsoleApp.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}