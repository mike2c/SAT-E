namespace Core.Entity
{
    public class TechnicalSupport : Task
    {
        public int TechnicalSupportId { get; set; }
        public Solution Solution { get; set; }
    }
}
