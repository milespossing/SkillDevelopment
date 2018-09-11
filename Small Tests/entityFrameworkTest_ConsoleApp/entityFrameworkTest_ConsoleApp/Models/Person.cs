using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace entityFrameworkTest_ConsoleApp.Models
{
    public class Person : ModelBase
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual PersonAddress PersonAddress { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual ICollection<Course> CoursesTeaching { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public Person() { }
        public Person(string lastName, string firstName) : this()
        {
            LastName = lastName;
            FirstName = firstName;
        }
        public Person(string lastName, string firstName, DateTime birthDate) : this(lastName,firstName)
        {
            BirthDate = birthDate;
        }
    }
}