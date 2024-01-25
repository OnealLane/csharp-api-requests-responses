using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public interface IRepository
    {

        Student PostStudent(Student student);

        IEnumerable<Student> GetStudents();

        Student GetStudentByFirstName(string firstName);

        Student PutStudent(string firstname, string newFname, string newLname);

        Student DeleteStudent(string firstName);
    }
}
