namespace EmployeesManagement.Tests.Mocks
{
    using AutoMapper;
    using EmployeesManagement.Web.Mapping;

    public static class MockAutoMapper
    {
        static MockAutoMapper()
        {
            Mapper.Initialize(config => config.AddProfile<AutoMapperProfile>());
        }

        public static IMapper GetMapper() => Mapper.Instance;
    }
}
