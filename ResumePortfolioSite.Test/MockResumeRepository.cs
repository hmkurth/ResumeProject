using ResumePortfolioSite.Models;
using ResumePortfolioSite.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumePortfolioSite.Test
{
    public class MockResumeRepository : IResumeRepository
    {
        public void AddEducationItem(Education educationItem)
        {
           
        }

        public bool AnyEducationItemsExist()
        {
            return true;
        }

        public List<Education> GetAllEducationEntries()
        {
            return new List<Education>();
        }
    }
}
