using ResumePortfolioSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePortfolioSite.ViewModels
{
    public class ResumeIndexViewModel
    {
        public List<Education> EducationItems { get; set; } = new List<Education>();
        public List<Job> JobItems { get; set; } = new List<Job>();
        public List<Skill> SkillItems { get; set; } = new List<Skill>();
    }
}
