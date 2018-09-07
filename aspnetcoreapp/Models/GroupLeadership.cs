using System;

namespace aspnetcoreapp.Models
{
    public class GroupLeadership
    {
        public int ID { get; set; }
        public DateTime AppointmentDate { get; set; }

        public virtual Person Person { get; set; }
        public virtual Group Group { get; set; }
    }
}