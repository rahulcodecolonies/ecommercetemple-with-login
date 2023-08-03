using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public partial class MUser
    {
     
        
        public long UserId { get; set; }
        public string? UserName { get; set; }
        public string? ProfilePicPath { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public bool? EmailConfirmed { get; set; }
        public string? PhoneNumber { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
        public bool? TwoFactorEnabled { get; set; }
        public bool? LockoutEnabled { get; set; }
        public long? UserTypeId { get; set; }
        public string? Password { get; set; }
        public string? PasswordHash { get; set; }
        public string? NavigateToken { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual MUserType? UserType { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<MAddress> MAddresses { get; set; }
        public virtual ICollection<MCompany> MCompanies { get; set; }
        public virtual ICollection<Talent> Talents { get; set; }
    }
}
