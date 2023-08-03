using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class MUserType
    {
        public MUserType()
        {
            MUsers = new HashSet<MUser>();
        }

        public long UserTypeId { get; set; }
        public string? UserTypeCode { get; set; }
        public string? UserTypeDescription { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<MUser> MUsers { get; set; }
    }
}
