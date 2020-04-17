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
    }
}
