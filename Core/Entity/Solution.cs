using System.Collections.Generic;

namespace Core.Entity
{
    public class Solution
    {
        public int SolutionId { get; set; }
        public string SolutionName { get; set; }
        public virtual List<SolutionHistory> SolutionHistories { get; set; }
    }
}
