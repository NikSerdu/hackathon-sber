using Microsoft.AspNetCore.Mvc;
using SberCase.Contracts;
using SberCase.Models;

namespace SberCase.Controllers
{
    public class ObligationController : BaseController<ObligationController>
    {
        [HttpPost("/obligations")]
        public async Task<ActionResult<Obligation>> CreateObligation([FromBody] ObligationCreate dto)
        {
            await oblicationRepository.CreateAsync(dto.ToDomain());
            return StatusCode(201, MessageResp.New(201, "created"));
        }
    }
}
