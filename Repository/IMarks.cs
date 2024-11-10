using UnitOfWork.Model;

namespace UnitOfWork.Repository
{
    public interface IMarks
    {
        public Mark AddMarks(Mark mark);

        public Mark GetMarksByStudentId(int id);

        public Mark UpdateMarksByStudentId(int id, MarksModel marks);
    }
}
