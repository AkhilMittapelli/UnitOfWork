using UnitOfWork.Model;

namespace UnitOfWork.Repository
{
    public interface IStudentService
    {
        public Student AddStudent(Student student);

        public Student GetStudent(int id);

        public List<Student> GetStudents();

    }
}