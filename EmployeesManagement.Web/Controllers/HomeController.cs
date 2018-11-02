using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeesManagement.Web.Models;
using EmployeesManagement.Services.Interfaces;

namespace EmployeesManagement.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICompaniesService companyService;

        public HomeController(ICompaniesService companyService)
        {
            this.companyService = companyService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await this.companyService.GetAllCompaniesAsync();

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
