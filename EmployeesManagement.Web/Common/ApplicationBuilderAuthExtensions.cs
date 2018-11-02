namespace EmployeesManagement.Web.Common
{
    using EmployeesManagement.Data;
    using EmployeesManagement.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class ApplicationBuilderAuthExtensions
    {
        private const string ExperienceLevelA = "A";
        private const string ExperienceLevelB = "B";
        private const string ExperienceLevelC = "C";
        private const string ExperienceLevelD = "D";
        //private const string DefaultSecondAdminUsername = "adminKristiana";
        //private const string DefaultFirstUserUsername = "firstUser";
        //private const string DefaultFirstAdminEmail = "stela@megicofsewing.com";
        //private const string DefaultSecondAdminEmail = "kristiana@megicofsewing.com";
        //private const string DefaultFirstUserEmail = "firstuser@fff.fff";

        //private static IdentityRole[] roles =
        //{
        //    new IdentityRole("Administrator")
        //};

        public static async void SeedDatabase(this IApplicationBuilder app)
        {
            var serviceFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            var scope = serviceFactory.CreateScope();

            using (scope)
            {
                var context = scope.ServiceProvider.GetService<EmployeesManagementContext>();
                context.Database.Migrate();
                               
                if (!await context.ExperienceLevelTypes.AnyAsync())
                {
                    ExperienceLevelType[] experienceLevels =
                    {
                        new ExperienceLevelType(){ Name = ExperienceLevelA },
                        new ExperienceLevelType(){ Name = ExperienceLevelB },
                        new ExperienceLevelType(){ Name = ExperienceLevelC },
                        new ExperienceLevelType(){ Name = ExperienceLevelD },
                    };

                    await context.ExperienceLevelTypes.AddRangeAsync(experienceLevels);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
