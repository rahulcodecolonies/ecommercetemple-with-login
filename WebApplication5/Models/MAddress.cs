using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class MAddress
    {
        public MAddress()
        {
            MCompanies = new HashSet<MCompany>();
            Talents = new HashSet<Talent>();
        }

        public long AddressId { get; set; }
        public long? UserId { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public long? CityId { get; set; }
        public long? StateId { get; set; }
        public long? CountryId { get; set; }
        public string? PostalCode { get; set; }
        public bool? IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual MCity? City { get; set; }
        public virtual MCountry? Country { get; set; }
        public virtual MState? State { get; set; }
        public virtual MUser? User { get; set; }
        public virtual ICollection<MCompany> MCompanies { get; set; }
        public virtual ICollection<Talent> Talents { get; set; }
    }
}
