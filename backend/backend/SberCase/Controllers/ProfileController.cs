using Microsoft.AspNetCore.Mvc;
using SberCase.Contracts;
using SberCase.Models;

namespace SberCase.Controllers
{
    public class ProfileController : BaseController<ProfileController>
    {
        [HttpGet("/profiles/{id}")]
        public async Task<ActionResult<Profile>> GetProfile([FromRoute] int id)
        {
            var profile = await profileRepository.GetByIdAsync(id);
            if (profile == null)
                return NotFound(MessageResp.New(404, "profile not found"));
            return Ok(profile);
        }

        [HttpPost("/profiles")]
        public async Task<ActionResult<Profile>> CreateProfile([FromBody] ProfileCreate dto)
        {
            await profileRepository.CreateAsync(dto.ToDomain());
            return StatusCode(201, MessageResp.New(201, "created"));
        }
    }
}
