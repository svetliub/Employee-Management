namespace EmployeesManagement.Tests.Controllers.CompaniesControllerTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using EmployeesManagement.Common.BindingModels;
    using EmployeesManagement.Web.Controllers;
    using System.Threading.Tasks;
    using EmployeesManagement.Services;
    using EmployeesManagement.Data;
    using System.Linq;
    using EmployeesManagement.Tests.Mocks;

    [TestClass]
    public class AddTests
    {
        private const string companyName = "New company name";
        private const string bulstat = "111111111";
        private const string address = "new company address";
        private const string town = "Sofia";
        
        private EmployeesManagementContext dbContext;
        private CompaniesService companiesService;
        private TownsService townsService;
        
        [TestMethod]
        public async Task AddCompany_WithProperCompany_ShouldAddCorrectly()
        {
            var companyModel = new CompanyCreationBindingModel()
            {
                Name = companyName,
                Bulstat = bulstat,
                Address = address,
                TownName = town
            };

            var controller = new CompaniesController(companiesService, townsService);

            // Act

            await controller.Add(companyModel);
            var company = this.dbContext.Companies.First();

            // Assert
            Assert.AreEqual(1, this.dbContext.Companies.Count());
            Assert.AreEqual(companyName, company.Name);
            Assert.AreEqual(bulstat, company.Bulstat);
            Assert.AreEqual(address, company.Address);
            Assert.AreEqual(town, company.Town.Name);
        }

        [TestInitialize]
        public void InitializeTests()
        {
            this.dbContext = MockDbContext.GetDbContext();
            var mapper = MockAutoMapper.GetMapper();
            this.townsService = new TownsService(dbContext, mapper);
            this.companiesService = new CompaniesService(dbContext, mapper, townsService);
        }
    }
}