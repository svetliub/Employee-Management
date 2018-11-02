namespace EmployeesManagement.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static EmployeesManagement.Common.Constants.WebConstants;

    public class Company
    {
        public int CompanyId { get; set; }

        [Required(ErrorMessage = RequiredName)]
        [MinLength(CompanyNameMinLength), MaxLength(CompanyNameMaxLength)]
        public string Name { get; set; }

        [Required(ErrorMessage = RequiredBulstat)]
        [MinLength(BulstatLength), MaxLength(BulstatLength)]
        public string Bulstat { get; set; }

        public int TownId { get; set; }
        public Town Town { get; set; }

        [MinLength(AddressNameMinLength), MaxLength(AddressNameMaxLength)]
        public string Address { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}