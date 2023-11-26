using Microsoft.AspNetCore.Mvc;
using SberCase.Contracts;
using SberCase.Models;

namespace SberCase.Controllers
{
    public class ProfileController : BaseController<ProfileController>
    {
        [HttpPost("/profiles")]
        public async Task<ActionResult<Profile>> CreateProfile([FromBody] ProfileCreate dto)
        {
            await profileRepository.CreateAsync(dto.ToDomain());
            return StatusCode(201, MessageResp.New(201, "created"));
        }

        [HttpGet("/profiles/{id}")]
        public async Task<ActionResult<Profile>> GetProfileById(string id)
        {
            var profile =  await profileRepository.GetByIdAsync(Convert.ToInt32(id));
            if (profile != null) return profile;
            return StatusCode(404, MessageResp.New(404, "Profile not found"));

        }
    }
}
