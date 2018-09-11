using System;
using System.Linq;
using entityFrameworkTest_ConsoleApp.DAL;
using entityFrameworkTest_ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace entityFrameworkTest_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleContextFactory factory = new PeopleContextFactory();
            PeopleContext context = factory.CreateDbContext();
            Person miles = context.People.First(p => p.FirstName == "Miles");
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
