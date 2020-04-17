using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePortfolioSite.Models
{
    public class Education
    {
        public int EducationId { get; set; }
        public string SchoolName { get; set; }
        public int StartYear { get; set; }
        public string StartMonth { get; set; }
        
        public int? GraduationYear { get; set; }
        public string GraduationMonth { get; set; }

    }
}
