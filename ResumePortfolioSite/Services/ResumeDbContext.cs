using Microsoft.EntityFrameworkCore;
using ResumePortfolioSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePortfolioSite.Services
{
    public class ResumeDbContext : DbContext, IResumeRepository
    {
        public ResumeDbContext(DbContextOptions<ResumeDbContext> options)
            : base(options)
        {

        }

        DbSet<Education> Educations { get; set; }

        public List<Education> GetAllEducationEntries()
        {
            return Educations.ToList();
        }

        public bool AnyEducationItemsExist()
        {
            return Educations.Any();
        }

        public void AddEducationItem(Education educationItem)
        {
            Educations.Add(educationItem);
            SaveChanges();
        }
    }
}
