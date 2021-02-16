using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project3_FinalExam.Services;
using Project3_FinalExam.ViewModels;

namespace Project3_FinalExam.Controllers
{
    public class FacultyController : Controller
    {

        private readonly IGetFaculty _facultyRepository;

        public FacultyController(IGetFaculty facultyRepository)
        {
            _facultyRepository = facultyRepository;
        }



        public async Task<IActionResult> GetFaculty()
        {
            var allFaculty = await _facultyRepository.GetAllFaculty();
            var sortedFaculty = allFaculty.OrderBy(f => f.username);

/*            //var allResearch = await _researchRepository.GetAllResearch();
           var sortedResearch = allResearch.OrderBy(f => f.username);*/

            var facultyViewModel = new FacultyViewModel()
            {
                Faculty = sortedFaculty.ToList(),
                Title = "Meet your Faculty",
/*               Research = allResearch.ToList(),
*/
            };
            return View(facultyViewModel);
        }

        
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
