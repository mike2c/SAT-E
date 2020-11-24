namespace Core.Entity
{
    public class Employee
    {
        public enum GenderType
        {
            Masculino,
            Femenino
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderType Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CelPhone { get; set; }
        public string Branch { get; set; }
        public string Province { get; set; }
        public bool IsActive { get; set; }
    }
}