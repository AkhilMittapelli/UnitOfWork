using UnitOfWork.Data;
using UnitOfWork.Model;

namespace UnitOfWork.Repository.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly StudentContext studentContext;
        public StudentService(StudentContext _studentContext) {
            studentContext = _studentContext;
        }
        public Student AddStudent(Student student)
        {
            studentContext.Students.Add(student);
            studentContext.SaveChanges();

            return student;
        }

        public Student GetStudent(int id)
        {
           
            var student = studentContext.Students.Find(id);

           
            if (student != null)
            {
                return student; 
            }

            
            throw new KeyNotFoundException($"Student with ID {id} not found.");
        }

        public List<Student> GetStudents()
        {
           return studentContext.Students.ToList();

            
        }
    }
}
