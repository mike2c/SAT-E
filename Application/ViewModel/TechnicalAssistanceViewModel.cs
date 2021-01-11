using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class TechnicalAssistanceViewModel : TaskViewModel
    {
        [Display(Name = "Tipo de problema")]
        public int? ProblemTypeId { get; set; }
    }
}
