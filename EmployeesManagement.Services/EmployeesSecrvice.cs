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

    public class EmployeesSecrvice : BaseService, IEmployeesSecrvice
    {
        public EmployeesSecrvice(EmployeesManagementContext dbContext, IMapper mapper) 
            : base(dbContext, mapper)
        { }

        public async Task<Employee> AddEmployeeAsync(EmployeeCreationBindingModel model)
        {
            var employee = this.Mapper.Map<Employee>(model);
            await this.DbContext.Employees.AddAsync(employee);
            await this.DbContext.SaveChangesAsync();

            return employee;
        }

        public async Task DeleteEmployee(int id)
        {
            var employee = await GetEmployeeById(id);
            this.DbContext.Employees.Remove(employee);

            await this.DbContext.SaveChangesAsync();
        }

        public async Task<EmployeeEditBindingModel> GetEmployeeEditAsync(int id)
        {
            var employee = await GetEmployeeById(id);

            var model = this.Mapper.Map<EmployeeEditBindingModel>(employee);

            return model;
        }

        public async Task<Employee> EditEmployeeAsync(EmployeeEditBindingModel model)
        {
            var dbEmployee = this.DbContext.Employees.Find(model.EmployeeId);

            dbEmployee.CompanyId = model.CompanyId;
            dbEmployee.ExperienceLevelId = model.ExperienceLevelId;
            dbEmployee.FirstName = model.FirstName;
            dbEmployee.LastName = model.LastName;
            dbEmployee.Salary = model.Salary;
            dbEmployee.StartDate = model.StartDate;
            dbEmployee.VacationDays = model.VacationDays;

            await this.DbContext.SaveChangesAsync();

            return dbEmployee;
        }

        public async Task<IEnumerable<EmployeeConciseViewModel>> GetAllEmployeesAsync(int companyId)
        {
            var employees = await this.DbContext.Employees
                .Where(e => e.CompanyId == companyId)
                .Include(e => e.ExperienceLevel)
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToListAsync();

            var models = this.Mapper.Map<IEnumerable<EmployeeConciseViewModel>>(employees);

            return models;
        }
        
        public async Task<EmployeeDetailsViewModel> GetEmployeeDetailsAsync(int id)
        {
            var employee = await GetEmployeeById(id);

            var model = this.Mapper.Map<EmployeeDetailsViewModel>(employee);

            return model;
        }
        
        private async Task<Employee> GetEmployeeById(int id)
        {
            var employee = await this.DbContext.Employees
                .Include(e => e.ExperienceLevel)
                .Include(e => e.Company)
                .FirstOrDefaultAsync(e => e.EmployeeId == id);

            return employee;
        }
    }
}
