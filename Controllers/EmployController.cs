using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Project3_FinalExam.Services;
using Project3_FinalExam.ViewModels;

namespace Project3_FinalExam.Controllers
{
    public class EmployController : Controller
    {

        private readonly IGetEmploy _employRepository;

        public EmployController(IGetEmploy employRepository)
        {
            _employRepository = employRepository;
        }
        /*public IActionResult Index()
        {
            return View();
        }*/

        public async Task<IActionResult> GetEmploy()
        {
            var allEmploy = await _employRepository.GetAllEmploy();
            var sortedEmploy = allEmploy.OrderBy(f => f.employer);
            var employViewModel = new EmployViewModel()
            {
                Employ = allEmploy.ToList(),
                Title = "Our Most Entrusted Employers"
            };
            return View(employViewModel);
        }
    }
}
