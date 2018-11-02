namespace EmployeesManagement.Common.BindingModels
{
    using System.ComponentModel.DataAnnotations;
    using static EmployeesManagement.Common.Constants.WebConstants;

    public class CompanyCreationBindingModel
    {
        [Required(ErrorMessage = RequiredName)]
        [MinLength(CompanyNameMinLength), MaxLength(CompanyNameMaxLength)]
        public string Name { get; set; }

        [Required(ErrorMessage = RequiredBulstat)]
        [MinLength(BulstatLength), MaxLength(BulstatLength)]
        public string Bulstat { get; set; }

        [Required(ErrorMessage = RequiredTown)]
        [MinLength(TownNameMinLength), MaxLength(TownNameMaxLength)]
        [Display(Name = "Town Name")]
        public string TownName { get; set; }

        public int TownId { get; set; }

        [MinLength(AddressNameMinLength), MaxLength(AddressNameMaxLength)]
        public string Address { get; set; }
    }
}