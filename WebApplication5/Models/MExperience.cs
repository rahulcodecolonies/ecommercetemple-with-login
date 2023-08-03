using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class MExperience
    {
        public long ExperienceId { get; set; }
        public string? ExperienceName { get; set; }
        public bool? IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
