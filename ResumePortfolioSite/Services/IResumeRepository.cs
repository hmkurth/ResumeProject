using ResumePortfolioSite.Models;
using System.Collections.Generic;

namespace ResumePortfolioSite.Services
{
    public interface IResumeRepository
    {
        List<Education> GetAllEducationEntries();
        bool AnyEducationItemsExist();
        void AddEducationItem(Education educationItem);
    }
}