using Microsoft.AspNetCore.Mvc;
using StudentDatabase.Model;
using StudentDatabase.Services.StudentDirectory;

namespace StudentDatabase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentDirectoryController : ControllerBase
    {
        private readonly IStudentDirectory _studentDirectory;

        public StudentDirectoryController(IStudentDirectory studentDirectory)
        {
            _studentDirectory = studentDirectory;
        }

        [HttpGet]
        [Route("GetStudents")]
        public List<Student> GetStudents()
        {
            return _studentDirectory.GetStudents();
        }

        [HttpPost]
        [Route("AddStudent/{firstName}/{lastName}/{hobby}")]
        public List<Student> AddStudent(string firstName, string lastName, string hobby)
        {
            return _studentDirectory.AddStudent(firstName, lastName, hobby);
        }

        [HttpDelete]
        [Route("DeleteStudent/{firstName}")]
        public List<Student> DeleteStudent(string firstName)
        {
            return _studentDirectory.DeleteStudent(firstName);
        }
    }
}