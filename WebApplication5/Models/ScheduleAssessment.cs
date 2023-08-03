using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class ScheduleAssessment
    {
        public long AssessmentId { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public long? JobId { get; set; }
        public long? UserId { get; set; }
        public bool? IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
