using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class MCity
    {
        public MCity()
        {
            MAddresses = new HashSet<MAddress>();
        }

        public long CityId { get; set; }
        public string CityName { get; set; } = null!;
        public long? StateId { get; set; }

        public virtual ICollection<MAddress> MAddresses { get; set; }
    }
}
