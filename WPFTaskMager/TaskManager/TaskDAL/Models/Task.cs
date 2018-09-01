using System;

namespace TaskDAL.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
    }
}