using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using UsersReyestr.Api.Models.Students;
using UsersReyestr.Api.Services.Foundations.Students;

namespace UsersReyestr.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController:Controller
    {
        private readonly IStudentService studentService;

        public StudentsController(IStudentService studentService)=>
            this.studentService = studentService;

        [HttpPost]
        public async ValueTask<ActionResult<Student>> PostStudentAsync(Student student)
        {
            try
            {
                return await this.studentService.AddStudentAsync(student);
            }
            catch(Exception  ex)
            {
              return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async ValueTask<ActionResult<IQueryable<Student>>> GetStudentAsync()
        {
            try
            {
                var students = await this.studentService.RetrieveAllStudentsAsync();
                return Ok(students);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
