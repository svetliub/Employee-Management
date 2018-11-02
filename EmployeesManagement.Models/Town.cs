namespace EmployeesManagement.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Town
    {
        public Town()
        {
            this.Companies = new List<Company>();
        }

        public int TownId { get; set; }

        [Required]
        [MinLength(2), MaxLength(60)]
        public string Name { get; set; }

        public ICollection<Company> Companies { get; set; }
    }
}
