namespace EmployeesManagement.Services
{
    using AutoMapper;
    using EmployeesManagement.Common.BindingModels;
    using EmployeesManagement.Common.ViewModels;
    using EmployeesManagement.Data;
    using EmployeesManagement.Models;
    using Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CompaniesService : BaseService, ICompaniesService
    {
        private readonly ITownsService townsService;

        public CompaniesService(EmployeesManagementContext dbContext, IMapper mapper, ITownsService townsService) 
            : base(dbContext, mapper)
        {
            this.townsService = townsService;
        }

        public async Task<Company> AddCompanyAsync(CompanyCreationBindingModel model)
        {
            var company = this.Mapper.Map<Company>(model);            
            await this.DbContext.Companies.AddAsync(company);
            await this.DbContext.SaveChangesAsync();

            return company;
        }

        public async Task DeleteCompany(int id)
        {
            var company = await GetCompanyById(id);
            this.DbContext.Companies.Remove(company);

            await this.DbContext.SaveChangesAsync();
        }

        public async Task<CompanyEditBindingModel> GetCompanyEditAsync(int id)
        {
            var company = await GetCompanyById(id);

            var model = this.Mapper.Map<CompanyEditBindingModel>(company);

            return model;
        }

        public async Task<Company> EditCompanyAsync(CompanyEditBindingModel model)
        {
            var dbCompany = await GetCompanyById(model.CompanyId);

            var town = await this.townsService.GetTownByName(model.TownName);

            if (town == null)
            {
                var townToAdd = new TownCreationBindingModel { Name = model.TownName };
                town = await this.townsService.AddTownAsync(townToAdd);
            }

            dbCompany.TownId = town.TownId;
            dbCompany.Address = model.Address;
            dbCompany.Bulstat = model.Bulstat;
            dbCompany.Name = model.Name;

            await this.DbContext.SaveChangesAsync();

            return dbCompany;
        }        

        public async Task<IEnumerable<CompanyConciseViewModel>> GetAllCompaniesAsync()
        {
            var companies = await this.DbContext.Companies
                .Include(c => c.Town)
                .OrderBy(c => c.Name)
                .ToListAsync();

            var models = this.Mapper.Map<IEnumerable<CompanyConciseViewModel>>(companies);

            return models;
        }        

        public async Task<CompanyDetailsViewModel> GetCompanyDetailsAsync(int id)
        {
            var company = await GetCompanyById(id);

            var model = this.Mapper.Map<CompanyDetailsViewModel>(company);

            return model;
        }
        
        public async Task<Company> GetCompanyById(int id)
        {
            var company = await this.DbContext.Companies
                .Include(c => c.Town)
                .FirstOrDefaultAsync(e => e.CompanyId == id);

            return company;
        }
    }
}
