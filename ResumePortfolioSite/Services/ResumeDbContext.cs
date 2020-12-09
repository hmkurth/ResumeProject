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
        DbSet<Job> Jobs { get; set; }
        DbSet<Skill> Skills { get; set; }

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
        private bool EducationItemExists(int id)
        {
            return Educations.Any(e => e.EducationId == id);
        }

        public async Task<Education> FindEducationItemAsync(int id)
        {
            return await Educations.FindAsync(id);
        }

        internal bool AnyJobItemsExist()
        {
            throw new NotImplementedException();
        }

        public void RemoveEducationItem(Education education)
        {
            Educations.Remove(education);
            SaveChanges();
        }



        //Jobs




        public bool JobItemExists(int id)
        {
            return Jobs.Any();
        }

        public List<Job> GetAllJobEntries()
        {
            return Jobs.ToList();
        }
        public bool JobItemsExists(int id)
        {
            return Jobs.Any(e => e.JobId == id);
        }

        public async Task<Job> FindJobItemAsync(int id)
        {
            return await Jobs.FindAsync(id);
        }

        public async Task<int> UpdateJobItem(int id, Job job)
        {

            Entry(job).State = EntityState.Modified;

            try
            {
                await SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobItemExists(id))
                {
                    return -1;
                }
                else
                {
                    throw;
                }
            }

            return job.JobId;
        }

        public void AddJobItem(Job jobItem)
        {
            Jobs.Add(jobItem);
            SaveChanges();
        }

        public void RemoveJobItem(Job job)
        {
           Jobs.Remove(job);
            SaveChanges();
        }


        //Skills


        public List<Skill> GetAllSkillEntries()
        {
            return Skills.ToList();
        }

        public async Task<Skill> FindSkillItemAsync(int id)
        {
            return await Skills.FindAsync(id);
        }

        public async Task<int> UpdateSkillItem(int id, Skill skill)
        {

            Entry(skill).State = EntityState.Modified;

            try
            {
                await SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkillItemExists(id))
                {
                    return -1;
                }
                else
                {
                    throw;
                }
            }

            return skill.SkillId;
        }

        public void AddSkillItem(Skill skillItem)
        {
            Skills.Add(skillItem);
            SaveChanges();
        }

        public void RemoveSkillItem(Skill skill)
        {
            Skills.Remove(skill);
            SaveChanges();
        }

        private bool SkillItemExists(int id)
        {
            return Skills.Any(e => e.SkillId == id);
        }
        private bool SkillItemsExists(int id)
        {
            return Skills.Any(e => e.SkillId == id);
        }

        


        #endregion
    }
}
