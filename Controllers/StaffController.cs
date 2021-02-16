using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project3_FinalExam.Services;
using Project3_FinalExam.ViewModels;

namespace Project3_FinalExam.Controllers
{
    public class StaffController : Controller
    {

        private readonly IGetStaff _staffRepository;

        public StaffController(IGetStaff staffRepository)
        {
            _staffRepository = staffRepository;
        }

       

        public async Task<IActionResult> GetStaff()
        {
            var allStaff = await _staffRepository.GetAllStaff();
            var sortedStaff = allStaff.OrderBy(f => f.username);
            var staffViewModel = new StaffViewModel()
            {
                Staff = sortedStaff.ToList(),
                Title = "Meet our Staff"
            };
            return View(staffViewModel);
        }
    }
}
