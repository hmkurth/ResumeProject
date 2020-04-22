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

        #region Education methods
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

        public async Task<int> UpdateEducationItem(int id, Education education)
        {
            Entry(education).State = EntityState.Modified;

            try
            {
                await SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EducationItemExists(id))
                {
                    return -1;
                }
                else
                {
                    throw;
                }
            }

            return education.EducationId;
        }

        public async Task<Education> FindEducationItemAsync(int id)
        {
            return await Educations.FindAsync(id);
        }

        public void RemoveEducationItem(Education education)
        {
            Educations.Remove(education);
            SaveChanges();
        }

        private bool EducationItemExists(int id)
        {
            return Educations.Any(e => e.EducationId == id);
        }
        #endregion
    }
}
