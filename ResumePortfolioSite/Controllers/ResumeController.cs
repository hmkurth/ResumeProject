using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResumePortfolioSite.Models;
using ResumePortfolioSite.ViewModels;

namespace ResumePortfolioSite.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            ResumeIndexViewModel resumeIndexViewModel = new ResumeIndexViewModel();

            return View(resumeIndexViewModel);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
