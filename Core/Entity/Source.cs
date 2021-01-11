namespace Core.Entity
{
    public class Source
    {
        public int SourceId { get; set; }
        public string SourceName { get; set; }
        public bool IsActive { get; set; }
        public TaskType TaskType { get; set; }
    }
}