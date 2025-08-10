using System.Collections.Generic;
using System.Threading.Tasks;
using UsersReyestr.Web.Models.Students;

namespace UsersReyestr.Web.Brokers
{
    public partial class ApiBroker
    {
        const string studentBaseUrl = "api/Students";

        public async ValueTask<List<Student>> GetAllArksAsync() =>
            await this.GetAsync<List<Student>>(studentBaseUrl);
    }
}
