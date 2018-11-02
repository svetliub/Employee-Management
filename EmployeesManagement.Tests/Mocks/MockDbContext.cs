namespace EmployeesManagement.Tests.Mocks
{
    using EmployeesManagement.Data;
    using Microsoft.EntityFrameworkCore;
    using System;

    public static class MockDbContext
    {
        public static EmployeesManagementContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<EmployeesManagementContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            return new EmployeesManagementContext(options);
        }
    }
}
