namespace EmployeesManagement.Services.Interfaces
{
    using EmployeesManagement.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IExperienceLevelsSecrvice
    {
        Task<IEnumerable<ExperienceLevelType>> GetAllExperienceLevelTypesAsync();
    }
}
