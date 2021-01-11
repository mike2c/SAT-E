using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class TaskViewModel
    {
        public int TaskId { get; set; }
        [Required(ErrorMessage = "Debe de ingresar un nombre para la tarea")]
        
        [Display(Name = "Nombre de la tarea")]
        public String TaskName { get; set; }
        
        [Display(Name = "Fecha de atención")]
        public DateTime TaskDate { get; set; }
        
        [Display(Name = "Fecha de inicio")]
        public DateTime? StartDate { get; set; }
        
        [Display(Name = "Fecha de finalización")]
        public DateTime? EndDate { get; set; }
        
        [Display(Name = "Duración estimada")]
        public float EstimatedTime { get; set; }
        
        [Display(Name = "Duración real")]
        public float ActualTime { get; set; }
        
        [Display(Name = "Fuente")]
        [Required]
        public int SourceId { get; set; }        
        
        [Display(Name = "Atendido por")]
        public int AttendedByUserId { get; set; }
        
        [Display(Name = "Asignado por")]
        public int ?AssignedByUserId { get; set; }
        
        [Display(Name = "Asignado a")]
        public int ?AssignedToUserId { get; set; }
        
        public int EmployeeId { get; set; }        
        
        [Required]        
        [Display(Name = "Estado")]
        public State State { get; set; }        
        
        [Required]        
        [Display(Name = "Prioridad")]
        public Priority Priority { get; set; }
        
        [Required]
        [Display(Name = "Tipo de tarea")]
        public TaskType TaskType { get; set; }
    }
}
