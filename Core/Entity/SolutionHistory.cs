using System;
using System.Collections.Generic;

namespace Core.Entity
{
    public class SolutionHistory
    {
        public int SolutionHistoryId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string SolutionDescription { get; set; }
        public Solution Solution { get; set; }
        public User User { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}