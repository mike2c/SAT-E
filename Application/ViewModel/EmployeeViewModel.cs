using Core.Entity;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModel
{
    public class EmployeeViewModel
    {
        [Display(Name = "ID Empleado")]
        public int EmployeeId { get; set; }
        
        [Display(Name = "Nombres")]
        public string FirstName { get; set; }
        
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [Display(Name = "Genero")]
        public Employee.GenderType Gender { get; set; }

        [EmailAddress]
        [Display(Name = "Correo")]
        public string Email { get; set; }
        
        [Phone]
        [Display(Name = "Teléfono")]
        public string Phone { get; set; }
        
        [Display(Name = "Extensión telefónica")]
        public string PhoneExtension { get; set; }
        
        [Display(Name = "Teléfono Celular")]
        public string CelPhone { get; set; }
        
        [Display(Name = "Sucursal")]
        public int BranchId { get; set; }
        
        [Display(Name = "Area")]
        public int DepartmentId { get; set; }
        
        [Display(Name = "Activo")]
        public bool IsActive { get; set; }
    }
}
