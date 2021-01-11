using System;
using System.Collections.Generic;

namespace Core.Entity
{
    public class SolutionHistory
    {
        public int SolutionHistoryId { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string SolutionDescription { get; set; }
        public ProblemType Solution { get; set; }
        public User User { get; set; }
        public List<Attachment> Attachments { get; set; }
    }
}