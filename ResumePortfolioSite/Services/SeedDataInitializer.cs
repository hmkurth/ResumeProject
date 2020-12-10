using ResumePortfolioSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePortfolioSite.Services
{
    public class SeedDataInitializer
    {
        private ResumeDbContext _resumeDbContext;

        public SeedDataInitializer(ResumeDbContext resumeDbContext)
        {
            _resumeDbContext = resumeDbContext;
        }

        public void Seed()
        {
            // This is where we can add data to the database
            if (!_resumeDbContext.AnyEducationItemsExist())
            {
                Education educationItem = new Education();
                educationItem.SchoolName = "Madison College";
                educationItem.StartYear = 2019;
                educationItem.StartMonth = "September";
                educationItem.Degree = "IT - Web Software";

                _resumeDbContext.AddEducationItem(educationItem);

                Education anotherEducationItem = new Education();
                anotherEducationItem.SchoolName = "Fort Hays University";
                anotherEducationItem.StartYear = 2013;
                anotherEducationItem.StartMonth = "September";
                anotherEducationItem.Degree = "None, Studied Sociology";

                _resumeDbContext.AddEducationItem(anotherEducationItem);

                Education yetanotherEducationItem = new Education();
                yetanotherEducationItem.SchoolName = "Northland College";
                yetanotherEducationItem.StartYear = 1999;
                yetanotherEducationItem.StartMonth = "September";
                yetanotherEducationItem.Degree = "None, Studied Liberal Arts";

                _resumeDbContext.AddEducationItem(yetanotherEducationItem);
            }


            if (!_resumeDbContext.AnySkillItemsExist())
            {

                Skill mostRecentSkill = new Skill();
                mostRecentSkill.SkillName = "Java Programming";
                mostRecentSkill.StartYear = 2020;
                mostRecentSkill.Description = "learned java coding";
               

                _resumeDbContext.AddSkillItem(mostRecentSkill);

            }

            if (!_resumeDbContext.AnyJobItemsExist())
            {
                Job jobItem = new Job();
                jobItem.CompanyName = "Epic Systems";
                jobItem.StartYear = 2007;
                jobItem.DateEnded = 2019;
                jobItem.StartMonth = "May";
                jobItem.Position = "Chef";

                _resumeDbContext.AddJobItem(jobItem);


            }
        }
    }
}
