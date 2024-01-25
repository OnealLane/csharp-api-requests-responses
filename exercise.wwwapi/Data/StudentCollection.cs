using exercise.wwwapi.Models;

namespace exercise.wwwapi.Data
{
    public class StudentCollection : IStudentData
    {
        private List<Student> _students = new List<Student>()
        {
            new Student() { FirstName="Nathan",LastName="King" },
            new Student() { FirstName="Dave", LastName="Ames" }
        };

        public Student Add(Student student)
        {            
            _students.Add(student);

            return student;
        }

        public Student AddStudent(Student student)
        {
            _students.Add(student);
            return student;
        }

        public Student DeleteStudent(string firstName)
        {
            Student s = _students.Where(x => x.FirstName == firstName).FirstOrDefault();
            _students.Remove(s);
            return s;
        }

        public List<Student> getAll()
        {
            return _students.ToList();
        }

        public Student GetStudentByFN(string firstName)
        {
            return _students.Where(x => x.FirstName == firstName).FirstOrDefault();
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }

        public Student UpdateStudent(string firstName, string newFname, string newLname)
        {
            var student = _students.Where(x => x.FirstName == firstName).FirstOrDefault();

            student.FirstName = newFname;
            student.LastName = newLname;
            return student;

        }
    };


}
