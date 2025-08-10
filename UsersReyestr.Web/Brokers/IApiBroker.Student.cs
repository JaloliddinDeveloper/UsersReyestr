using System.Collections.Generic;
using System.Threading.Tasks;
using UsersReyestr.Web.Models.Students;

namespace UsersReyestr.Web.Brokers
{
    public partial interface IApiBroker
    {
        ValueTask<List<Student>> GetAllArksAsync();
    }
}
