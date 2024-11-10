using System.ComponentModel.DataAnnotations;

namespace UnitOfWork.Model
{
    public class Mark
    {
        [Key]
        public int MarksId { get; set; }

        public int marks {  get; set; }
       
        public Student student { get; set; }
        public int StudentId { get; set; }  

        
    }
}
