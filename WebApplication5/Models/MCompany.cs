using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class MCompany
    {
        public MCompany()
        {
            Clients = new HashSet<Client>();
        }

        public long CompanyId { get; set; }
        public string? CompanyLogo { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyDescription { get; set; }
        public string? CompanyWebsite { get; set; }
        public long? UserId { get; set; }
        public long? AddressId { get; set; }
        public string? CompanyRegistrationCertificate { get; set; }
        public string? Brochure { get; set; }
        public string? Pancard { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual MAddress? Address { get; set; }
        public virtual MUser? User { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
