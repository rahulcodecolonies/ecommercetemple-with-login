using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class MLocation
    {
        public long LocationId { get; set; }
        public string? LocationName { get; set; }
        public bool? IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
