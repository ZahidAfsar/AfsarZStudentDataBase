using AfsarZStudentDataBase.Model;

namespace AfsarZStudentDataBase.Services.StudentDirectoryService;

    public interface IStudentDirectoryService
    {
        List<Student> GetStudents();

        List<Student> AddStudent(string firstName, string lastName, string hobby);

        List<Student> DeleteStudent(string firstName);
    }
