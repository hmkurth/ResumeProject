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
                anotherEducationItem.SchoolName = "Northland College";
                anotherEducationItem.StartYear = 1999;
                anotherEducationItem.StartMonth = "September";
                anotherEducationItem.Degree = "None, Studied Liberal Arts";

                _resumeDbContext.AddEducationItem(anotherEducationItem);
            }
            if (!_resumeDbContext.AnyJobItemsExist())
            {

                Job mostRecentJob = new Job();
                mostRecentJob.CompanyName = "Epic Systems";
                mostRecentJob.StartYear = 2007;
                mostRecentJob.DateEnded = 1/21/2019;
                mostRecentJob.StartMonth = "May";
                mostRecentJob.Position = "Chef";

                _resumeDbContext.AddJobItem(mostRecentJob);

            }
        }
    }
}
