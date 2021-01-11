using System.Collections.Generic;

namespace Core.Entity
{
    public class Employee
    {
        public enum GenderType
        {
            Masculino = 'M', Femenino = 'F'
        }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public string Email { get; set; }        
        public string Phone { get; set; }
        public string PhoneExtension { get; set; }
        public string CelPhone { get; set; }
        public Branch Branch { get; set; }
        public Department Department { get; set; }
        public bool IsActive { get; set; }


        // Navigation
        public List<Task> Tasks { get; set; }
    }
}