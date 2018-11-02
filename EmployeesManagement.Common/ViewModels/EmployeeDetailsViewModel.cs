namespace EmployeesManagement.Common.ViewModels
{
    public class EmployeeDetailsViewModel
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string ExperienceLevel { get; set; }
        
        public string Company { get; set; }
        
        public string StartDate { get; set; }

        public decimal Salary { get; set; }

        public int VacationDays { get; set; }
    }
}
