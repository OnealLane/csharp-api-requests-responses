using exercise.wwwapi.Models;
using exercise.wwwapi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Diagnostics.Metrics;

namespace exercise.wwwapi.Endpoints
{
    public static class StudentEndpoint
    {



        public static void ConfigureStudentEndpoint(this WebApplication app)
        {
            var studentGroup = app.MapGroup("students");

            studentGroup.MapGet("/", GetStudents);
            studentGroup.MapPost("/", PostStudents);
            studentGroup.MapGet("/{firstName}", GetStudentFN);
            studentGroup.MapPut("/{firstName}", PutStudent);
            studentGroup.MapDelete("/{firstName}", DeleteStudent);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetStudents(IRepository repository)
        {
            return TypedResults.Ok(repository.GetStudents());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetStudentFN(string firstName, IRepository repository)
        {
            var student = repository.GetStudentByFirstName(firstName);
            return student != null ? TypedResults.Ok(student) : TypedResults.NotFound();

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> PostStudents(Student student, IRepository repository)
        {
            var newStudent = repository.PostStudent(student);
            return TypedResults.Created(" ", newStudent);
        }



        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> PutStudent(string firstName, string newFname, string newLname, Student student, IRepository repository)
        {
            var newStudent = repository.PutStudent(firstName, newFname, newLname);
            return TypedResults.Created(" ", newStudent);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteStudent(string firstName, IRepository repository)
        {
            var student = repository.GetStudentByFirstName(firstName);
            repository.DeleteStudent(firstName);
            return TypedResults.Ok(student);
        }

    }
}



