
using Microsoft.AspNetCore.Mvc;
using SberCase.Contracts;
using SberCase.Models;

namespace SberCase.Controllers
{
    public class ApplicationController : BaseController<ApplicationController>
    {
        [HttpGet("/applications")]
        public async Task<IEnumerable<Application>> GetApplications()
        {
            return await applicationRepository.GetAllAsync();
        }

        [HttpGet("/applications/{id}")]
        public async Task<ActionResult<Application>> GetApplication([FromRoute] int id)
        {
            var application = await applicationRepository.GetByIdAsync(id);
            if (application == null) 
                return NotFound(MessageResp.New(404, "application not found"));
            return application;
        }

        [HttpPatch("/applications/{id}")]
        public async Task<ActionResult<Application>> PatchApplication([FromRoute] int id, [FromBody] PatchApplication appDto)
        {
            var application = await applicationRepository.GetByIdAsync(id);
            if (application == null)
                return NotFound(MessageResp.New(404, "application not found"));
            if (appDto.Decision != null)
                application.Decision = appDto.Decision;
            if (appDto.Comment != null)
                application.Comment = appDto.Comment;
            await applicationRepository.UpdateAsync(application);
            return Ok(MessageResp.New(200, "success"));
        }

        [HttpPost("/applications")]
        public async Task<ActionResult<Application>> CreateApplication([FromBody] ApplicationCreate dto)
        {
            await applicationRepository.CreateAsync(dto.ToDomain());
            return StatusCode(201, MessageResp.New(201, "created"));
        }
    }
}
