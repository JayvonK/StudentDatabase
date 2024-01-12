using StudentDatabase.Data;
using StudentDatabase.Model;

namespace StudentDatabase.Services.StudentDirectory;

public class StudentDirectory : IStudentDirectory
{
    private readonly DataContext _data;

    public StudentDirectory(DataContext data)
    {
        _data = data;
    }
    public List<Student> AddStudent(string name, string lastName, string hobby)
    {
        Student newStudent = new();
        newStudent.FirstName = name;
        newStudent.LastName = lastName;
        newStudent.Hobby = hobby;

        _data.Students.Add(newStudent);
        _data.SaveChanges();

        return _data.Students.ToList();
    }

    public List<Student> DeleteStudent(string name)
    {
        var existingStudent = _data.Students.FirstOrDefault(firstName => firstName.FirstName == name);

        if(existingStudent != null){
            _data.Students.Remove(existingStudent);
            _data.SaveChanges();
        }

        return _data.Students.ToList();
    }

    public List<Student> GetStudents()
    {
        return _data.Students.ToList();
    }
}
