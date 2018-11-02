namespace EmployeesManagement.Services
{
    using AutoMapper;
    using EmployeesManagement.Data;
    using EmployeesManagement.Models;
    using EmployeesManagement.Services.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ExperienceLevelsSecrvice : BaseService, IExperienceLevelsSecrvice
    {
        public ExperienceLevelsSecrvice(EmployeesManagementContext dbContext, IMapper mapper) 
            : base(dbContext, mapper)
        { }

        public async Task<IEnumerable<ExperienceLevelType>> GetAllExperienceLevelTypesAsync()
        {
            var experienceLevelTypes = await this.DbContext.ExperienceLevelTypes
               .OrderBy(c => c.Name)
               .ToListAsync();

            return experienceLevelTypes;
        }
    }
}
