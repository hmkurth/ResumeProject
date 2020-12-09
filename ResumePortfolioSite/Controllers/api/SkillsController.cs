using Microsoft.AspNetCore.Mvc;
using ResumePortfolioSite.Models;
using ResumePortfolioSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePortfolioSite.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    { 

        private readonly IResumeRepository _resumeRepository;

        public SkillsController(IResumeRepository resumeRepository)
        {
            _resumeRepository = resumeRepository;
        }

        // GET: api/Skills
        [HttpGet]
        public IEnumerable<Skill> GetSkills()
        {
            return _resumeRepository.GetAllSkillEntries();
        }

        // GET: api/Skill/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSkill([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var skill = await _resumeRepository.FindSkillItemAsync(id);

            if (skill == null)
            {
                return NotFound();
            }

            return Ok(skill);
        }

        // PUT: api/Skill/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSkill([FromRoute] int id, [FromBody] Skill skill)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != skill.SkillId)
            {
                return BadRequest();
            }

            var resultId = await _resumeRepository.UpdateSkillItem(id, skill);

            return NoContent();
        }

        // POST: api/Skills
        [HttpPost]
        public IActionResult PostSkill([FromBody] Skill skill)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _resumeRepository.AddSkillItem(skill);

            return CreatedAtAction("GetSkill", new { id = skill.SkillId }, skill);
        }

        // DELETE: api/Skill/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkill([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var skill = await _resumeRepository.FindSkillItemAsync(id);
            if (skill == null)
            {
                return NotFound();
            }

            _resumeRepository.RemoveSkillItem(skill);

            return Ok(skill);
        }
    }
}
