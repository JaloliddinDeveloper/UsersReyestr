using System.Linq;
using System.Threading.Tasks;
using UsersReyestr.Api.Models.Students;

namespace UsersReyestr.Api.Services.Foundations.Students
{
    public interface IStudentService
    {
        ValueTask<Student> AddStudentAsync(Student student);
        ValueTask<IQueryable<Student>> RetrieveAllStudentsAsync();
    }
}
