using Microsoft.EntityFrameworkCore;
using SberCase.Data;
using SberCase.Models;
using SberCase.Repositories.Interfaces;

namespace SberCase.Repositories.Impls
{
    public class ReportRepository : BaseRepository<Report, int>, IReportRepository
    {
        public ReportRepository(DatabaseContext context) : base(context)
        {

        }

        public async Task<Report?> GetByApplicationId(int applicationId) => 
            await _context.Reports.FirstOrDefaultAsync(e => e.ApplicationId == applicationId);

        public async Task<bool> IsReportExist(int applicationId) =>
            await _context.Reports.AnyAsync(e => e.ApplicationId == applicationId);
    }
}
