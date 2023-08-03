using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class MState
    {
        public MState()
        {
            MAddresses = new HashSet<MAddress>();
        }

        public long StateId { get; set; }
        public string StateName { get; set; } = null!;
        public long? CountryId { get; set; }

        public virtual MCountry? Country { get; set; }
        public virtual ICollection<MAddress> MAddresses { get; set; }
    }
}
