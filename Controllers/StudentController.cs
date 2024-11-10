using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork.Model;
using UnitOfWork.Repository;

namespace UnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)

        {
            _studentService = studentService;
        }

        [HttpPost]

        public Student AddStudent(Student student)
        {

            var Student1 = _studentService.AddStudent(student);

            return Student1;
        }
    }
}
