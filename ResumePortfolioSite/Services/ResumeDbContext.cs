using Microsoft.EntityFrameworkCore;
using ResumePortfolioSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePortfolioSite.Services
{
    public class ResumeDbContext : DbContext
    {
        public ResumeDbContext(DbContextOptions<ResumeDbContext> options)
            : base(options)
        {

        }

        DbSet<Education> Educations { get; set; }
    }
}
