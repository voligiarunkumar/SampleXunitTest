using LMS.Web.Areas.Demos.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Web.Areas.Demos.Controllers
{
    public class TransferDataController : Controller
    {
        /// <summary>
        ///     Transfer Data from Controller using ViewBag
        /// </summary>
        /// <returns></returns>
        public IActionResult Demo1()
        {
            ViewBag.Name = "Manoj Kumar Sharma - using ViewBag";
            return View();
        }

        /// <summary>
        ///     Transfer Data from Controller using ViewData
        /// </summary>
        /// <returns></returns>
        public IActionResult Demo2()
        {
            ViewData["Name"] = "Manoj Kumar Sharma - using ViewData";
            return View();
        }

        /// <summary>
        ///     Transfer Data from Controller using TempData
        /// </summary>
        /// <returns></returns>
        public IActionResult Demo3()
        {
            TempData["Name"] = "Manoj Kumar Sharma - using TempData";
            return View();
        }

        /// <summary>
        ///     Transfer Data from Controller using ViewModel
        /// </summary>
        /// <returns></returns>
        public IActionResult Demo4()
        {
            EmployeeViewModel viewModel = new EmployeeViewModel()
            {
                Id = 5,
                EmployeeName = "Manoj Kumar Sharma",
                DateOfBirth = new System.DateTime(1980, 1, 1),
                Salary = 5000M,
                IsEnabled = true
            };
            return View(viewModel);
        }
    }
}
