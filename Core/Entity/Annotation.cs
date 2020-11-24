namespace Core.Entity
{
    public class Annotation
    {
        public int AnnotationId { get; set; }
        public string AnnotationBody { get; set; }
        public User User { get; set; }
    }
}