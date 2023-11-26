using SberCase.Models;

namespace SberCase.Repositories.Interfaces
{
    public interface IObligationRepository : IBaseRepository<Obligation, int>
    {
        Task<List<Obligation>> GetByReportId(int reportId);
    }
}
