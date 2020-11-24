using System.Collections.Generic;

namespace Core.Entity
{
    public class Attachment
    {
        public int AttachmentId { get; set; }
        public string FileName { get; set; }
        public string Extension{ get; set; }
        public string Path { get; set; }

        public User User { get; set; }
        public List<SolutionHistory> SolutionHistories { get; set; }
    }
}