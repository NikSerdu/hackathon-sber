using SberCase.Data;
using SberCase.Models;
using SberCase.Repositories.Interfaces;

namespace SberCase.Repositories.Impls
{
    public class ApplicationRepository : BaseRepository<Application, int>, IApplicationRepository
    {
        public ApplicationRepository(DatabaseContext context) : base(context)
        {
            
        }
    }
}
