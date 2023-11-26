using SberCase.Data;
using SberCase.Models;
using SberCase.Repositories.Interfaces;

namespace SberCase.Repositories.Impls
{
    public class ObligationRepository : BaseRepository<Obligation, int>, IObligationRepository
    {
        public ObligationRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
