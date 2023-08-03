using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class MProjectStatus
    {
        public MProjectStatus()
        {
            Projects = new HashSet<Project>();
        }

        public long StatusId { get; set; }
        public string? StatusType { get; set; }
        public string? StatusDesciprtion { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
