using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using UnitOfWork.Data;
using UnitOfWork.Model;

namespace UnitOfWork.Repository
{
    public class MarkService : IMarks
    {
        private readonly StudentContext _studentContext;

        public MarkService(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }


        public Mark AddMarks(Mark mark)
        {
            _studentContext.Marks.Add(mark);
            _studentContext.SaveChanges();

            return mark;
        }

        public Mark GetMarksByStudentId(int id)
        {
            var mark = _studentContext.Marks
                .Where(m => m.StudentId == id)
                .Include(m => m.student) 
                .FirstOrDefault(); 

            return mark;
        }

        public Mark UpdateMarksByStudentId(int id, MarksModel marks)
        {
           
            var updateMark = _studentContext.Marks
                .Where (m => m.StudentId == id)
                .Include(m => m.student)
                .FirstOrDefault();

            if (updateMark == null)
            {
                
                var newMark = new Mark
                {
                    StudentId = id,
                    marks = marks.marks 
                };

              
                _studentContext.Marks.Add(newMark);
                _studentContext.SaveChanges();

                
                return newMark;
            }

            
            updateMark.marks = marks.marks;

           
            _studentContext.SaveChanges();

           
            return updateMark;
        }


    }

}
