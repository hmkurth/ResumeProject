using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResumePortfolioSite.Models;
using ResumePortfolioSite.Services;
using ResumePortfolioSite.ViewModels;

namespace ResumePortfolioSite.Controllers
{
    public class ResumeController : Controller
    {
        private IResumeRepository _resumeRepository;

        public ResumeController(IResumeRepository resumeDbContext)
        {
            _resumeRepository = resumeDbContext;
        }

        public IActionResult Index()
        {
            ResumeIndexViewModel resumeIndexViewModel = new ResumeIndexViewModel();

            resumeIndexViewModel.EducationItems = _resumeRepository.GetAllEducationEntries();
            resumeIndexViewModel.JobItems = _resumeRepository.GetAllJobEntries();
            resumeIndexViewModel.SkillItems = _resumeRepository.GetAllSkillEntries();

            return View(resumeIndexViewModel);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
