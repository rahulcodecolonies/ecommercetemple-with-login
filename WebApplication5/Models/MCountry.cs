using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class MCountry
    {
        public MCountry()
        {
            MAddresses = new HashSet<MAddress>();
            MStates = new HashSet<MState>();
        }

        public long CountryId { get; set; }
        public string CountryShortName { get; set; } = null!;
        public string CountryName { get; set; } = null!;
        public int PhoneCode { get; set; }

        public virtual ICollection<MAddress> MAddresses { get; set; }
        public virtual ICollection<MState> MStates { get; set; }
    }
}
