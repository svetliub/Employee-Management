namespace EmployeesManagement.Common.Constants
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class WebConstants
    {
        //Employee constants
        public const string RequiredCompany = "The company is required! Please enter a company!";
        public const string RequiredFirstName = "The first name  is required! Please enter a first name!";
        public const string RequiredLastName = "The last name is required! Please enter a last name!";
        public const string RequiredSalary = "The salary is required! Please enter a salary value!";
        public const string RequiredVacationDays = "The vacation days are required! Please enter vacation days!";
        public const string RequiredExperienceLevel = "The experience level is required! Please enter a experience level!";
        public const int FirstNameMinLength = 3;
        public const int FirstNameMaxLength = 50;
        public const int LastNameMinLength = 3;
        public const int LastNameMaxLength = 50;
        public const int MinVacationDays = 0;
        public const int MaxVacationDays = 100;

        //Company constants
        public const string RequiredName = "The name is required! Please enter a name!";
        public const string RequiredBulstat = "The Bulstat is required! Please enter a Bulstat!";
        public const string RequiredTown = "The town is required! Please enter a town!";
        public const int CompanyNameMinLength = 2;
        public const int CompanyNameMaxLength = 60;
        public const int BulstatLength = 9;
        public const int TownNameMinLength = 2;
        public const int TownNameMaxLength = 60;
        public const int AddressNameMinLength = 2;
        public const int AddressNameMaxLength = 60;
    }
}