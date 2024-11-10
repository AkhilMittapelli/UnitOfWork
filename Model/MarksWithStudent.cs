using System.Text.Json.Serialization;

namespace UnitOfWork.Model
{
    public class MarksWithStudent
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [JsonIgnore]
        public Mark Marks { get; set; }

        public int marks {  get; set; } 
    }
}
