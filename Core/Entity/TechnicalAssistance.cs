namespace Core.Entity
{
    public class TechnicalAssistance : Task
    {
        public int TechnicalAssistanceId { get; set; }
        public Solution Solution { get; set; }
    }
}
