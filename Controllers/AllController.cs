using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork.Migrations;
using UnitOfWork.Model;
using UnitOfWork.Repository;

namespace UnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllController : ControllerBase
    {
        private readonly All all;

        public AllController(All all)
        {
            this.all = all;
        }

        [HttpPost]
        public IActionResult Add([FromBody] StudentMarksModel studentMarksModel)
        {
            var student = new Student
            {
                FirstName = studentMarksModel.StudentMOdel.FirstName,
                LastName = studentMarksModel.StudentMOdel.LastName,
            };

            var studentSave = all.StudentService.AddStudent(student);

            var markEntity = new Mark
            {
                marks = studentMarksModel.MarkModel.marks,
                StudentId = studentSave.StudentId,
            };

            var markSave = all.MarkService.AddMarks(markEntity);

            return Ok(new { message = "Student and marks added successfully." });
        }
        [HttpGet("{id}")]
        public IActionResult GetMarks(int id)
        {
            var student = all.StudentService.GetStudent(id);
            if (student == null)
            {
                return NotFound("Student not found.");
            }

            var studentMarks = all.MarkService.GetMarksByStudentId(id);


            var response = new MarksWithStudent
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                StudentId = student.StudentId,
                marks = studentMarks.marks
            };

            return Ok(response);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateMark(int id, [FromBody] MarksModel marks)
        {
            if (marks == null)
            {
                var newUpdate = new Mark
                {
                    marks= marks.marks
                };
            }


            var updatedMark = all.MarkService.UpdateMarksByStudentId(id, marks);

                
            if (updatedMark == null)
            {
                return NotFound("Mark not found for the specified student.");
            }


            return Ok(updatedMark);
        }
    }



    }

