using System.Collections.Generic;

namespace Core.Entity
{
    public class ProblemType
    {
        public int ProblemTypeId { get; set; }
        public string ProblemName { get; set; }
        public string ProblemDescription { get; set; }
        public SolutionHistory CurrentSolution { get; set;}
        public List<SolutionHistory> SolutionHistories { get; set; }
    }
}
