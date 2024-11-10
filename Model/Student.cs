namespace UnitOfWork.Model
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }    

        public string LastName { get; set; }

        public List<Mark> Marks { get; set; }
    }
}
