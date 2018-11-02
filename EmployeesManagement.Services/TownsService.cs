namespace EmployeesManagement.Services
{
    using AutoMapper;
    using EmployeesManagement.Common.BindingModels;
    using EmployeesManagement.Data;
    using EmployeesManagement.Models;
    using EmployeesManagement.Services.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class TownsService : BaseService, ITownsService
    {
        public TownsService(EmployeesManagementContext dbContext, IMapper mapper) 
            : base(dbContext, mapper)
        { }

        public async Task<Town> AddTownAsync(TownCreationBindingModel model)
        {
            var town = this.Mapper.Map<Town>(model);
            await this.DbContext.Towns.AddAsync(town);
            await this.DbContext.SaveChangesAsync();

            return town;
        }

        public async Task<Town> GetTownByName(string townName)
        {
            var town = await this.DbContext
                .Towns
                .FirstOrDefaultAsync(t => t.Name == townName);

            return town;
        }
    }
}
