namespace EmployeesManagement.Services.Interfaces
{
    using EmployeesManagement.Common.BindingModels;
    using EmployeesManagement.Common.ViewModels;
    using EmployeesManagement.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICompaniesService
    {
        Task<Company> AddCompanyAsync(CompanyCreationBindingModel model);

        Task<Company> GetCompanyById(int id);

        Task<IEnumerable<CompanyConciseViewModel>> GetAllCompaniesAsync();

        Task<CompanyDetailsViewModel> GetCompanyDetailsAsync(int id);

        Task<CompanyEditBindingModel> GetCompanyEditAsync(int id);

        Task<Company> EditCompanyAsync(CompanyEditBindingModel model);

        Task DeleteCompany(int id);
    }
}
