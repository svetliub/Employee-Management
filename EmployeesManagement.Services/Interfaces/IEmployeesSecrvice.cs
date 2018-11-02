namespace EmployeesManagement.Services.Interfaces
{
    using EmployeesManagement.Common.BindingModels;
    using EmployeesManagement.Common.ViewModels;
    using EmployeesManagement.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IEmployeesSecrvice
    {
        Task<Employee> AddEmployeeAsync(EmployeeCreationBindingModel model);

        Task<IEnumerable<EmployeeConciseViewModel>> GetAllEmployeesAsync(int companyId);

        Task<EmployeeDetailsViewModel> GetEmployeeDetailsAsync(int id);

        Task<EmployeeEditBindingModel> GetEmployeeEditAsync(int id);

        Task<Employee> EditEmployeeAsync(EmployeeEditBindingModel model);

        Task DeleteEmployee(int id);
    }
}
