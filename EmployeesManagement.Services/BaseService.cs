namespace EmployeesManagement.Services
{
    using AutoMapper;
    using EmployeesManagement.Data;

    public class BaseService
    {
        public BaseService(EmployeesManagementContext dbContext, IMapper mapper)
        {
            this.DbContext = dbContext;
            this.Mapper = mapper;
        }

        protected EmployeesManagementContext DbContext { get; private set; }

        protected IMapper Mapper { get; private set; }
    }
}
