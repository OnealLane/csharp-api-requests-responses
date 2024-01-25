using exercise.wwwapi.Data;
using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public class Repository : IRepository
    {
        private IStudentData _studentDatabase;

        public Repository(IStudentData studentDatabase)
        {
            _studentDatabase = studentDatabase;
        }

        public Student PostStudent(Student student)
        {
            return (_studentDatabase.AddStudent(student));
        }

        public IEnumerable<Student> GetStudents()
        {
            return _studentDatabase.GetStudents();
        }

        public Student GetStudentByFirstName(string firstName)
        {
           return _studentDatabase.GetStudentByFN(firstName);
        }

        public Student PutStudent(string firstname, string newFname, string newLname)
        {
            return _studentDatabase.UpdateStudent(firstname, newFname, newLname);
        }

        public Student DeleteStudent(string firstName)
        {
            _studentDatabase.DeleteStudent(firstName);
            return _studentDatabase.GetStudentByFN(firstName);
        }
    }
}
