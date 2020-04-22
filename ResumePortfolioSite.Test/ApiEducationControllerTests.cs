using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResumePortfolioSite.Controllers.api;
using ResumePortfolioSite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumePortfolioSite.Test
{
    [TestClass]
    public class ApiEducationControllerTests
    {
        [TestMethod]
        public void GetEducationApiReturnType()
        {
            // Arrange 
            EducationsController educationsController = new EducationsController(new MockResumeRepository());

            // Act 
            var result = educationsController.GetEducations();

            // Assert
            Assert.IsInstanceOfType(result, typeof(List<Education>));
        }
    }
}