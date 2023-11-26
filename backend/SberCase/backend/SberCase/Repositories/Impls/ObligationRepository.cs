using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Obligation>> GetByReportId(int reportId) =>
            await _context.Obligations.Where(e => e.ReportId == reportId).ToListAsync();
    }
}
