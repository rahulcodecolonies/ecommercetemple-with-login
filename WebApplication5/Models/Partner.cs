using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class Partner
    {
        public Partner()
        {
            Clients = new HashSet<Client>();
        }

        public long PartnerId { get; set; }
        public string? PartnerName { get; set; }
        public string? Company { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
