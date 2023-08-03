using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class Client
    {
        public long ClientId { get; set; }
        public string? ClientName { get; set; }
        public long? CompanyId { get; set; }
        public long? PartnerId { get; set; }
        public long? TalentId { get; set; }
        public long? UserId { get; set; }
        public long? ProjectId { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual MCompany? Company { get; set; }
        public virtual Partner? Partner { get; set; }
        public virtual Talent? Talent { get; set; }
        public virtual MUser? User { get; set; }
    }
}
