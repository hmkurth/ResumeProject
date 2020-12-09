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

        public void AddJobItem(Job jobItem)
        {
            throw new NotImplementedException();
        }

        public void AddSkillItem(Skill skillItem)
        {
            throw new NotImplementedException();
        }

        public bool AnyEducationItemsExist()
        {
            return true;
        }

        public Task<Education> FindEducationItemAsync(int id)
        {
            return Task.FromResult(new Education());
        }

        public Task<Job> FindJobItemAsync(int id)
        {
            return Task.FromResult(new Job());
        }

        public Task<Skill> FindSkillItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public List<Education> GetAllEducationEntries()
        {
            return new List<Education>();
        }

        public List<Job> GetAllJobEntries()
        {
            throw new NotImplementedException();
        }

        public List<Skill> GetAllSkillEntries()
        {
            throw new NotImplementedException();
        }

        public void RemoveEducationItem(Education education)
        {
            
        }

        public void RemoveJobItem(Job job)
        {
            throw new NotImplementedException();
        }

        public void RemoveSkillItem(Skill skill)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEducationItem(int id, Education education)
        {
            return Task.FromResult(1);
        }

        public Task<int> UpdateJobItem(int id, Job job)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateSkillItem(int id, Skill skill)
        {
            throw new NotImplementedException();
        }

        
    }
}
