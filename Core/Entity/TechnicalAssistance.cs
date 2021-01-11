namespace Core.Entity
{
    public class TechnicalAssistance : Task
    {
        public int ?ProblemTypeId { get; set; }
        public ProblemType ProblemType { get; set; }
    }
}
