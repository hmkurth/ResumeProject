using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumePortfolioSite.Models;
using ResumePortfolioSite.Services;

namespace ResumePortfolioSite.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationsController : ControllerBase
    {
        private readonly IResumeRepository _resumeRepository;

        public EducationsController(IResumeRepository resumeRepository)
        {
            _resumeRepository = resumeRepository;
        }

        // GET: api/Educations
        [HttpGet]
        public IEnumerable<Education> GetEducations()
        {
            return _resumeRepository.GetAllEducationEntries();
        }

        // GET: api/Educations/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEducation([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var education = await _resumeRepository.FindEducationItemAsync(id);

            if (education == null)
            {
                return NotFound();
            }

            return Ok(education);
        }

        // PUT: api/Educations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEducation([FromRoute] int id, [FromBody] Education education)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != education.EducationId)
            {
                return BadRequest();
            }

            var resultId = await _resumeRepository.UpdateEducationItem(id, education);

            return NoContent();
        }

        // POST: api/Educations
        [HttpPost]
        public IActionResult PostEducation([FromBody] Education education)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _resumeRepository.AddEducationItem(education);

            return CreatedAtAction("GetEducation", new { id = education.EducationId }, education);
        }

        // DELETE: api/Educations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEducation([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var education = await _resumeRepository.FindEducationItemAsync(id);
            if (education == null)
            {
                return NotFound();
            }

            _resumeRepository.RemoveEducationItem(education);

            return Ok(education);
        }
    }
}
