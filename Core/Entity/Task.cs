using System;

namespace Core.Entity
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Problem { get; set; }
        public DateTime TaskDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float EstimatedTime { get; set; }
        public float ActualTime { get; set; }
        public Source Source { get; set; }
        public User AttendedBy { get; set; }
        public User AssignedBy { get; set; }
        public User AssingedTo { get; set; }
        public Employee Employee { get; set; }
        public State State { get; set; }
        public Priority Priority { get; set; }
        public TaskType IncidenceType { get; set; }
    }
}