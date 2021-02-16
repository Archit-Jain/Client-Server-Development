using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project3_FinalExam.Services;
using Project3_FinalExam.ViewModels;

namespace Project3_FinalExam.Controllers
{
    public class MinorController : Controller
    {
       /* public IActionResult Index()
        {
            return View();
        }*/

        private readonly IGetMinors _minorRepository;

        public MinorController(IGetMinors minorRepository)
        {
            _minorRepository = minorRepository;
        }

        public async Task<IActionResult> GetMinors()
        {
            var allMinors = await _minorRepository.GetAllMinors();
            //var sortedFaculty = allFaculty.OrderBy(f => f.username);
            var minorsViewModel = new MinorsViewModel()
            {
                Minors = allMinors.ToList(),
                Title = "UnderGraduation Minor List"
            };
            return View(minorsViewModel);
        }
    }
}
