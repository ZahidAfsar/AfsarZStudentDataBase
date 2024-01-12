using Microsoft.AspNetCore.Mvc;
using AfsarZStudentDataBase.Model;
using AfsarZStudentDataBase.Services.StudentDirectoryService;

namespace AfsarZStudentDataBase.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class StudentDataBaseController : ControllerBase
    {
       private readonly IStudentDirectoryService _studentDirectory;

        public StudentDataBaseController(IStudentDirectoryService studentDirectoryService)
        {
            _studentDirectory = studentDirectoryService;
        }

        [HttpGet]
        [Route("GetStudents")]
        public List<Student> GetStudents()
        {
            return _studentDirectory.GetStudents();
        }

        [HttpPost]
        [Route("AddStudent/{firstName}/{lastName}/{Hobby}")]
        public List<Student> AddStudent(string firstName, string lastName, string Hobby)
        {
            return _studentDirectory.AddStudent(firstName, lastName, Hobby);
        }

        [HttpDelete]
        [Route("DeleteStudent/{firstName}")]
        public List<Student> DeleteStudent(string firstName)
        {
            return _studentDirectory.DeleteStudent(firstName);
        }
    }
