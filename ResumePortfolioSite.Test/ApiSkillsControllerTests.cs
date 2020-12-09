using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResumePortfolioSite.Controllers.api;
using ResumePortfolioSite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumePortfolioSite.Test
{
    [TestClass]
    public class ApiSkillsControllerTests
    {
        [TestMethod]
        public void GetSkillApiReturnType()
        {
            // Arrange 
            SkillsController skillsController = new SkillsController(new MockResumeRepository());

            // Act 
            var result = skillsController.GetSkills();

            // Assert
            Assert.IsInstanceOfType(result, typeof(List<Skill>));
        }
    }
}