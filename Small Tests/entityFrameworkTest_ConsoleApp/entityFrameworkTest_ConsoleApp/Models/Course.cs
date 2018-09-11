using System;
using System.Collections.Generic;
using System.Text;

namespace entityFrameworkTest_ConsoleApp.Models
{
    public class Course : ModelBase
    {
        public string Name { get; set; }
        public int Credits { get; set; }

        public virtual Person Professor { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }

        public void AddStudent(Person person)
        {
            Registration r = new Registration();
            r.Person = person;
            Registrations.Add(r);
        }
        public void AddStudent(ICollection<Person> People)
        {
            foreach (Person person in People)
            {
                AddStudent(person);
            }
        }

        public Course()
        {
            Registrations = new List<Registration>();
        }
        public Course(string name, int credits) : this()
        {
            Name = name;
            Credits = credits;
        }
    }
}
