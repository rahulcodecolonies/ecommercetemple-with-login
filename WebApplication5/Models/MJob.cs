using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class MJob
    {
        public long JobId { get; set; }
        public string? JobName { get; set; }
        public string? JobShortDescription { get; set; }
        public string? JobDescription { get; set; }
        public string? SkillId { get; set; }
        public string? JobTypeId { get; set; }
        public string? LocationId { get; set; }
        public string? ExperienceId { get; set; }
        public bool? IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
