using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project3_FinalExam.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Services;
using Project3_FinalExam.ViewModels;

namespace Project3_FinalExam.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        private readonly IGetAbout _aboutRepository;

        public HomeController(IGetAbout aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }
        public async Task<IActionResult> GetAbout()
        {
            var allAbout = await _aboutRepository.GetAllAbout();
            // var sortedFaculty = allFaculty.OrderBy(f => f.username);
            var aboutViewModel = new AboutViewModel()
            {
                About = allAbout.ToList(),
                Title = "Welcome to RIT's iSchool, Home Page"
            };
            return View(aboutViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
