using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project3_FinalExam.Services;
using Project3_FinalExam.ViewModels;

namespace Project3_FinalExam.Controllers
{
    public class UnderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IGetUndergraduate _underGradRepository;

        public UnderController(IGetUndergraduate underGradRepository)
        {
            _underGradRepository = underGradRepository;
        }

        public async Task<IActionResult> Under()
        {
            //var getUnder = new GetUndergraduate();
            var under = await _underGradRepository.GetUnderGradDegrees();
            var underViewModel = new UndergradViewModel()
            {
                UnderGrads = under,
                Title = "Undergraduate Programs"
            };
            return View(underViewModel);
        }


    }
}
