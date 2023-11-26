using Microsoft.AspNetCore.Mvc;
using SberCase.Contracts;
using SberCase.Models;

namespace SberCase.Controllers
{
    [Route("/obligations/")]
    public class ObligationController : BaseController<ObligationController>
    {
        [HttpPost("")]
        public async Task<ActionResult<Obligation>> CreateObligation([FromBody] ObligationCreate dto)
        {
            await obligationRepository.CreateAsync(dto.ToDomain());
            return StatusCode(201, MessageResp.New(201, "created"));
        }
        [HttpGet("{reportId}")]
        public async Task<ActionResult<List<Obligation>>> GetReportObligations([FromRoute] int reportId) =>
            await obligationRepository.GetByReportId(reportId);
    }
}
