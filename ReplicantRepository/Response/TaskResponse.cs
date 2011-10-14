using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.Response
{
    class TaskResponse
    {
        public int? Id { get; set; }
        public int ProjectId { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public float PercentComplete { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Notes { get; set; }
        public int Rownumber { get; set; }
        public int BindingListindex { get; set; }
        public DateTime CompleteThrough { get; set; }
        public DateTime DeadLine { get; set; }
        public TimeSpan DurationResolved { get; set; }
        public DateTime EndDateTimeResolved { get; set; }
        public bool Expanded { get; set; }
        public bool IsRoot { get; set; }
        public bool IsSumary { get; set; }
        public int TaskLevel { get; set; }
        public bool Milestone { get; set; }
        public bool MilestoneResolved { get; set; }
    }
}
