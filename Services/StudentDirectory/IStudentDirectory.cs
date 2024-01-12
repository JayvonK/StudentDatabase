using StudentDatabase.Model;

namespace StudentDatabase.Services.StudentDirectory
{
    public interface IStudentDirectory
    {
        List<Student> GetStudents();

        List<Student> AddStudent(string name, string lastName, string hobby);

        List<Student> DeleteStudent(string name);
    }
}