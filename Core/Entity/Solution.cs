using System.Collections.Generic;

namespace Core.Entity
{
    public class Solution
    {
        public int SolutionId { get; set; }
        public string ProblemDescription { get; set; }
        public string SolutionDescription { get; set; }
        public SolutionHistory CurrentSolution { get; set;}
        public List<SolutionHistory> SolutionHistories { get; set; }

    }
}
