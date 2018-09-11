namespace entityFrameworkTest_ConsoleApp.Models
{
    public enum Grade
    {
        A,
        B,
        C,
        D,
        F
    }
    public class Registration : ModelBase
    {
        public Grade? Grade { get; set; }

        public int PersonID { get; set; }
        public virtual Person Person { get; set; }
        
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
    }
}