using Microsoft.AspNetCore.Mvc;
using SberCase.Repositories.Interfaces;

namespace SberCase.Controllers
{
    [Route("api/")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseController<T>
    {
        // TODO change this repository stuff to services
        private IApplicationRepository? _applicationRepository;
        private IObligationRepository? _obligationRepository;
        private IProfileRepository? _profileRepository;
        private IReportRepository? _reportRepository;
        private IUnderwriterRepository? _underwriterRepository;

        protected IApplicationRepository applicationRepository => _applicationRepository
            ??= HttpContext.RequestServices.GetRequiredService<IApplicationRepository>();
        protected IObligationRepository obligationRepository => _obligationRepository
            ??= HttpContext.RequestServices.GetRequiredService<IObligationRepository>();
        protected IProfileRepository profileRepository => _profileRepository
            ??= HttpContext.RequestServices.GetRequiredService<IProfileRepository>();
        protected IReportRepository reportRepository => _reportRepository
            ??= HttpContext.RequestServices.GetRequiredService<IReportRepository>();
        protected IUnderwriterRepository underwriterRepository => _underwriterRepository
            ??= HttpContext.RequestServices.GetRequiredService<IUnderwriterRepository>();


        private ILogger<T>? _logger;

        protected ILogger<T> Logger => _logger 
            ??= HttpContext.RequestServices.GetRequiredService<ILogger<T>>();
        

    }
}
