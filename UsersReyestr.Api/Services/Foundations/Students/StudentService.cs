using System.Linq;
using System.Threading.Tasks;
using UsersReyestr.Api.Brokers;
using UsersReyestr.Api.Models.Students;

namespace UsersReyestr.Api.Services.Foundations.Students
{
    public class StudentService: IStudentService
    {
        private readonly IStorageBroker storageBroker;

        public StudentService(IStorageBroker storageBroker)=>
            this.storageBroker = storageBroker;
        
        public async ValueTask<Student> AddStudentAsync(Student student)=>
           await this.storageBroker.InsertStudentAsync(student);

        public async ValueTask<IQueryable<Student>> RetrieveAllStudentsAsync() =>
            await this.storageBroker.SelectAllStudentsAsync();
    }
}
