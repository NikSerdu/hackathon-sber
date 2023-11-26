using SberCase.Data;
using SberCase.Models;
using SberCase.Repositories.Interfaces;

namespace SberCase.Repositories.Impls
{
    public class UnderwriterRepository : BaseRepository<Underwriter, int>, IUnderwriterRepository
    {
        public UnderwriterRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
