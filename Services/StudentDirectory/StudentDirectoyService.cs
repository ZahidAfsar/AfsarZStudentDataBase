using AfsarZStudentDataBase.Controllers;
using AfsarZStudentDataBase.Data;
using AfsarZStudentDataBase.Model;
using AfsarZStudentDataBase.Services.StudentDirectoryService;

namespace AfsarZStudentDataBase.Services.StudentDirectoryService;

    public class StudentDirectoryService : IStudentDirectoryService
    {
    private readonly DataContext _db;

    public StudentDirectoryService(DataContext db)
    {
        _db = db;
    }
    public List<Student> AddStudent(string nameFirst, string nameLast, string hobby)
    {
        Student newStudent = new();
        newStudent.firstName = nameFirst;
        newStudent.lastName = nameLast;
        newStudent.Hobby = hobby;

        _db.Students.Add(newStudent);
        _db.SaveChanges();

        return _db.Students.ToList();
    }

    public List<Student> DeleteStudent(string nameFirst)
    {
        var foundStudent = _db.Students.FirstOrDefault(firstName => firstName.firstName == nameFirst);

        if(foundStudent != null){
            _db.Students.Remove(foundStudent);
            _db.SaveChanges();
        }

        return _db.Students.ToList();
    }

    public List<Student> GetStudents()
    {
        return _db.Students.ToList();
    }
    }

