using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class MJobType
    {
        public long JobTypeId { get; set; }
        public string? JobType { get; set; }
        public bool? IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
