namespace UnitOfWork.Model
{
    public class MarkUpdate
    {
        public int MarksId { get; set; }

        public int marks { get; set; }
        public string FirstName { get; set; }

        public Student Student { get; set; }
        public int StudentId { get; set; }
    }
}
