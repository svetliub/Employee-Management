namespace EmployeesManagement.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ExperienceLevelType
    {
        public ExperienceLevelType()
        {
            this.Employees = new List<Employee>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
