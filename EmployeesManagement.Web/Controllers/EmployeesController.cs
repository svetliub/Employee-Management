namespace EmployeesManagement.Web.Controllers
{
    using EmployeesManagement.Common.BindingModels;
    using EmployeesManagement.Services.Interfaces;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    public class EmployeesController : Controller
    {
        private readonly IEmployeesSecrvice employeesSecrvice;
        private readonly ICompaniesService companiesService;
        private readonly IExperienceLevelsSecrvice experienceLevelsSecrvice;


        public EmployeesController(IEmployeesSecrvice employeesSecrvice, ICompaniesService companiesService,
            IExperienceLevelsSecrvice experienceLevelsSecrvice)
        {
            this.employeesSecrvice = employeesSecrvice;
            this.companiesService = companiesService;
            this.experienceLevelsSecrvice = experienceLevelsSecrvice;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var experienceLevels = await this.experienceLevelsSecrvice.GetAllExperienceLevelTypesAsync();
            var companies = await this.companiesService.GetAllCompaniesAsync();
            this.ViewData["ExperienceLevels"] = experienceLevels;
            this.ViewData["Companies"] = companies;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(EmployeeCreationBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var employee = await this.employeesSecrvice.AddEmployeeAsync(model);

            return this.RedirectToAction("Details", new { id = employee.EmployeeId });
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await this.employeesSecrvice.GetEmployeeDetailsAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var experienceLevels = await this.experienceLevelsSecrvice.GetAllExperienceLevelTypesAsync();
            var companies = await this.companiesService.GetAllCompaniesAsync();
            this.ViewData["ExperienceLevels"] = experienceLevels;
            this.ViewData["Companies"] = companies;

            var employee = await this.employeesSecrvice.GetEmployeeEditAsync(id);

            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeEditBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var employee = await this.employeesSecrvice.EditEmployeeAsync(model);

            return this.RedirectToAction("Details", new { id = employee.EmployeeId });
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees(int id)
        {
            var company = await this.companiesService.GetCompanyById(id);
            this.ViewData["Company"] = company.Name;
            var model = await this.employeesSecrvice.GetAllEmployeesAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await this.employeesSecrvice.DeleteEmployee(id);

            return this.RedirectToAction("Index", "Home");
        }
    }
}