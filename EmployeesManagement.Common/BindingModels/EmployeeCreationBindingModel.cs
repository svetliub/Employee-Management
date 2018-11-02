namespace EmployeesManagement.Common.BindingModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using static EmployeesManagement.Common.Constants.WebConstants;

    public class EmployeeCreationBindingModel
    {
        [Required(ErrorMessage = RequiredFirstName)]
        [MinLength(FirstNameMinLength), MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = RequiredLastName)]
        [MinLength(LastNameMinLength), MaxLength(LastNameMaxLength)]
        public string LastName { get; set; }

        [Required(ErrorMessage = RequiredExperienceLevel)]
        [Display(Name = "Experience Level")]
        public int ExperienceLevelId { get; set; }

        [Required(ErrorMessage = RequiredCompany)]
        [Display(Name = "Company")]
        public int CompanyId { get; set; }

        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = RequiredSalary)]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = RequiredVacationDays)]
        public int VacationDays { get; set; }
    }
}