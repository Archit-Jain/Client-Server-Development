using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project3_FinalExam.Services;
using Project3_FinalExam.ViewModels;


namespace Project3_FinalExam.Controllers
{
    public class GradController : Controller
    {
        private readonly IGetGraduate _gradRepository;

        public GradController(IGetGraduate gradRepository)
        {
            _gradRepository = gradRepository;
        }

  
        public async Task<IActionResult> GetGraduate()
        {
            var allGrad = await _gradRepository.GetGradDegrees();
            var GradViewModel = new GradViewModel()
            {

                Grads = allGrad,
                Title = "Graduate Programs"
            };
            
            return View(GradViewModel);
        }

        
    }
}
