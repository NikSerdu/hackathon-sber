﻿using Microsoft.AspNetCore.Mvc;
using SberCase.Contracts;
using SberCase.Models;

namespace SberCase.Controllers
{
    public class ReportController : BaseController<ReportController>
    {
        [HttpGet("/reports/{applicationId}")]
        public async Task<ActionResult<Report>> GetReportById([FromRoute] int applicationId)
        {
            var report = await reportRepository.GetByApplicationId(applicationId);
            if (report == null)
                return NotFound(MessageResp.New(404, "report not found"));
            return report;
        }

        [HttpPost("/reports/{applicationId}")]
        public async Task<ActionResult<Report>> CreateReport([FromRoute] int applicationId, [FromBody] ReportCreate dto)
        {
            if (await reportRepository.IsReportExist(applicationId))
                return BadRequest(MessageResp.New(400, "report to this application is already exist"));
            Report rep = dto.ToDomain();
            rep.ApplicationId = applicationId;
            await reportRepository.CreateAsync(rep);
            return StatusCode(201, MessageResp.New(201, "created"));
        }
    }
}
