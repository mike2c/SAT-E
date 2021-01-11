using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public Municipality Municipality  { get; set;}
    }
}
