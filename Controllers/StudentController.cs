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
        private readonly IUnitOfWork unitOfWork;

        public StudentController(IUnitOfWork _unitOfWork )
        {
            unitOfWork = _unitOfWork;
            
        }

        [HttpPost]

        public Student AddStudent(Student student)
        {

            unitOfWork.StudentService.AddStudent(student);

            return student;
        }


        [HttpGet]
        public IActionResult GetStudent(int id)
        {
            var student = unitOfWork.StudentService.GetStudent(id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }
        [HttpGet]

        public List<Student> Students()
        {

            return unitOfWork.StudentService.GetStudents();
        }
    }
}
