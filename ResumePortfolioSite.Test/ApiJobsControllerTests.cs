using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResumePortfolioSite.Controllers.api;
using ResumePortfolioSite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumePortfolioSite.Test
{
    [TestClass]
    public class ApiJobsControllerTests
    {
        [TestMethod]
        public void GetJobApiReturnType()
        {
            // Arrange 
            JobsController jobsController = new JobsController(new MockResumeRepository());

            // Act 
            var result = jobsController.GetJobs();

            // Assert
            Assert.IsInstanceOfType(result, typeof(List<Job>));
        }
    }
}