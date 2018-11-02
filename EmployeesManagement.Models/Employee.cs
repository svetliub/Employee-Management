namespace EmployeesManagement.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using static EmployeesManagement.Common.Constants.WebConstants;

    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = RequiredFirstName)]
        [MinLength(FirstNameMinLength), MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = RequiredLastName)]
        [MinLength(LastNameMinLength), MaxLength(LastNameMaxLength)]
        public string LastName { get; set; }

        public int ExperienceLevelId { get; set; }
        public ExperienceLevelType ExperienceLevel { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = RequiredSalary)]
        [Range(typeof(decimal), "0", "79228162514264337593543950335")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = RequiredVacationDays)]
        [Range(MinVacationDays, MaxVacationDays)]
        public int VacationDays { get; set; }
    }
}