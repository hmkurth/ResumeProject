using ResumePortfolioSite.Models;
using ResumePortfolioSite.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public Task<Education> FindEducationItemAsync(int id)
        {
            return Task.FromResult(new Education());
        }

        public List<Education> GetAllEducationEntries()
        {
            return new List<Education>();
        }

        public void RemoveEducationItem(Education education)
        {
            
        }

        public Task<int> UpdateEducationItem(int id, Education education)
        {
            return Task.FromResult(1);
        }
    }
}
