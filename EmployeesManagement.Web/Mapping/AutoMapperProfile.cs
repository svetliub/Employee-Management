namespace EmployeesManagement.Web.Mapping
{
    using AutoMapper;
    using EmployeesManagement.Common.BindingModels;
    using EmployeesManagement.Common.ViewModels;
    using EmployeesManagement.Models;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<Company, CompanyConciseViewModel>();
            this.CreateMap<Company, CompanyDetailsViewModel>()
                .ForMember(cd => cd.Town, opt => opt.MapFrom(c => c.Town.Name));
            this.CreateMap<CompanyCreationBindingModel, Company>();
            this.CreateMap<CompanyEditBindingModel, Company>();

            this.CreateMap<Employee, EmployeeConciseViewModel>()
                .ForMember(ec => ec.ExperienceLevel, opt => opt.MapFrom(e => e.ExperienceLevel.Name));
            this.CreateMap<Employee, EmployeeDetailsViewModel>()
                .ForMember(ec => ec.ExperienceLevel, opt => opt.MapFrom(e => e.ExperienceLevel.Name))
                .ForMember(ec => ec.Company, opt => opt.MapFrom(e => e.Company.Name))
                .ForMember(ec => ec.StartDate, opt => opt.MapFrom(e => e.StartDate.ToString("dd/MM/yyyy")));
            this.CreateMap<EmployeeCreationBindingModel, Employee>();
            this.CreateMap<EmployeeEditBindingModel, Employee>();

            this.CreateMap<TownCreationBindingModel, Town>();
        }
    }
}
