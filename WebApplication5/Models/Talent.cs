using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class Talent
    {
        public Talent()
        {
            Clients = new HashSet<Client>();
        }

        public long TalentId { get; set; }
        public long? UserId { get; set; }
        public string? Expertise { get; set; }
        public string? TechSkill { get; set; }
        public int? TotalExperienceYear { get; set; }
        public int? TotalExperienceMonth { get; set; }
        public int? ProjectCompleted { get; set; }
        public long? AddressId { get; set; }
        public string? LinkedInUrl { get; set; }
        public string? GithubUrl { get; set; }
        public string? DegreeTitle { get; set; }
        public string? UniversityName { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public decimal? ExpectedPayout { get; set; }
        public decimal? CurrentPayout { get; set; }
        public string? Cvurl { get; set; }
        public bool? IsFullTime { get; set; }
        public bool? IsInterested8hrsWork { get; set; }
        public bool? IsImmidiateJoin { get; set; }
        public string? PreferredWorkLocation { get; set; }
        public string? CommunicationRate { get; set; }
        public bool? IsCurrentlyWorking { get; set; }
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
