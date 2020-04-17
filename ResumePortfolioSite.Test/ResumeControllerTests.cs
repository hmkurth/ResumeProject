using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResumePortfolioSite.Controllers;

namespace ResumePortfolioSite.Test
{
    [TestClass]
    public class ResumeControllerTests
    {
        [TestMethod]
        public void IndexViewResultTest()
        {
            // Arrange
            MockResumeRepository mockResumeRepository = new MockResumeRepository();
            ResumeController resumeController = new ResumeController(mockResumeRepository);

            // Act 
            var result = resumeController.Index();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));

        }
    }
}
