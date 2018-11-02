namespace EmployeesManagement.Common.BindingModels
{
    using System.ComponentModel.DataAnnotations;
    using static EmployeesManagement.Common.Constants.WebConstants;

    public class TownCreationBindingModel
    {
        [Required]
        [MinLength(TownNameMinLength), MaxLength(TownNameMaxLength)]
        public string Name { get; set; }
    }
}
