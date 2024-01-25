using exercise.wwwapi.Models;

namespace exercise.wwwapi.Data
{
    public interface IStudentData
    {
        Student AddStudent(Student student);

        IEnumerable<Student> GetStudents();

        Student GetStudentByFN(string firstName);


        Student UpdateStudent(string firstName, string newFname, string newLname);

        Student DeleteStudent(string firstName);
    }
}
