using SberCase.Models;

namespace SberCase.Repositories.Interfaces
{
    public interface IReportRepository : IBaseRepository<Report, int>
    {
        Task<Report?> GetByApplicationId(int applicationId);
        Task<bool> IsReportExist(int applicationId);
    }
}
