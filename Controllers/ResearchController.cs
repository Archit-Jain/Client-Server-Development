using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project3_FinalExam.Services;
using Project3_FinalExam.ViewModels;

namespace Project3_FinalExam.Controllers
{
    public class ResearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IGetResearch _researchRepository;

        public ResearchController(IGetResearch researchRepository)
        {
            _researchRepository = researchRepository;
        }
        public async Task<IActionResult> GetResearch()
        {
            var allResearch = await _researchRepository.GetAllResearch();
            var sortedFaculty = allResearch.OrderBy(f => f.username);
            var researchViewModel = new ResearchViewModel()
            {
                Research = allResearch.ToList(),
                Title = "Research by faculty"
            };
            return View(researchViewModel);
        }
    }
}
