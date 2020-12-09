using ResumePortfolioSite.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResumePortfolioSite.Services
{
    public interface IResumeRepository
    {
        List<Education> GetAllEducationEntries();
        Task<Education> FindEducationItemAsync(int id);
        Task<int> UpdateEducationItem(int id, Education education);
        void AddEducationItem(Education educationItem);
        void RemoveEducationItem(Education education);

        List<Job> GetAllJobEntries();
        Task<Job> FindJobItemAsync(int id);
        Task<int> UpdateJobItem(int id, Job job);
        void AddJobItem(Job jobItem);
        void RemoveJobItem(Job job);


        List<Skill> GetAllSkillEntries();
        Task<Skill> FindSkillItemAsync(int id);
        Task<int> UpdateSkillItem(int id, Skill skill);
        void AddSkillItem(Skill skillItem);
        void RemoveSkillItem(Skill skill);
    }
}