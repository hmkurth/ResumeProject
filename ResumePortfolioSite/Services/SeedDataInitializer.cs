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
                educationItem.StartYear = 2020;
                educationItem.StartMonth = "September";
                educationItem.Degree = "AS, IT - Web Software";

                _resumeDbContext.AddEducationItem(educationItem);

                Education anotherEducationItem = new Education();
                anotherEducationItem.SchoolName = "UW Madison";
                anotherEducationItem.StartYear = 2015;
                anotherEducationItem.StartMonth = "September";
                anotherEducationItem.Degree = "BA, English";

                _resumeDbContext.AddEducationItem(anotherEducationItem);

            }
        }
    }
}
