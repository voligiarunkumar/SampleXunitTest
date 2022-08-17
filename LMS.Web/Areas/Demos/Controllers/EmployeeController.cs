﻿using Microsoft.AspNetCore.Mvc;

using LMS.Web.Areas.Demos.ViewModels;

namespace LMS.Web.Areas.Demos.Controllers
{
    [Area("Demos")]
    public class EmployeeController : Controller
    {
        // GET 
        // [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(EmployeeViewModel viewModel)
        {
            // 1. Authentication

            // 2. Authorization

            // 3. Validation (Perform server-side validation)
            if (ModelState.IsValid)
            {
                // Check if the DOB is greater than 18 years
                if( System.DateTime.Now.Year - 18 < viewModel.DateOfBirth.Year)
                {
                    ModelState.AddModelError(nameof(viewModel.DateOfBirth), "Date of Birth has to be greater than 18 years!");
                }
            }

            // 4. Activity/Action (perform server-side activity)
            if (ModelState.IsValid)
            {
                // update the database!

                return View("Confirmation");
            }

            // 5. Audit Logging 

            return View();
        }
    }
}
