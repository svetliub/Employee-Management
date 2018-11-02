namespace EmployeesManagement.Web.Controllers
{
    using System.Threading.Tasks;
    using EmployeesManagement.Common.BindingModels;
    using EmployeesManagement.Services.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    public class CompaniesController : Controller
    {
        private readonly ICompaniesService companyService;
        private readonly ITownsService townsService;

        public CompaniesController(ICompaniesService companyService, ITownsService townsService)
        {
            this.companyService = companyService;
            this.townsService = townsService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CompanyCreationBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var town = await this.townsService.GetTownByName(model.TownName);

            if (town == null)
            {
                var townToAdd = new TownCreationBindingModel { Name = model.TownName };
                town = await this.townsService.AddTownAsync(townToAdd);
            }

            model.TownId = town.TownId;

            var company = await this.companyService.AddCompanyAsync(model);

            return this.RedirectToAction("Details", new { id = company.CompanyId });
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await this.companyService.GetCompanyDetailsAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var company = await this.companyService.GetCompanyEditAsync(id);

            return View(company);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CompanyEditBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var company = await this.companyService.EditCompanyAsync(model);

            return this.RedirectToAction("Details", new { id = company.CompanyId });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await this.companyService.DeleteCompany(id);

            return this.RedirectToAction("Index", "Home");
        }
    }
}