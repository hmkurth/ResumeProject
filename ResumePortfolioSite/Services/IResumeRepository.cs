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
    }
}