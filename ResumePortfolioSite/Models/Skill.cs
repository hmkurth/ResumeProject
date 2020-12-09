using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePortfolioSite.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }

        public string Description { get; set; }
        public int StartYear { get; set; }
       
    }
}
