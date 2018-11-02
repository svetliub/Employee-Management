namespace EmployeesManagement.Services.Interfaces
{
    using EmployeesManagement.Common.BindingModels;
    using EmployeesManagement.Models;
    using System.Threading.Tasks;

    public interface ITownsService
    {
        Task<Town> AddTownAsync(TownCreationBindingModel model);

        Task<Town> GetTownByName(string townName);
    }
}
