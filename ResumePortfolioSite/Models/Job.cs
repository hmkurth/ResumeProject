using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePortfolioSite.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public string CompanyName { get; set; }

        public string Position { get; set; }
        public int StartYear { get; set; }
        public string StartMonth { get; set; }

        public int? DateEnded { get; set; }
        
    }
}
