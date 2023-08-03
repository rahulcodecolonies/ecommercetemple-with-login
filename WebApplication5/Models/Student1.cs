using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class Student1
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Course { get; set; }
        public string? Hobbies { get; set; }
    }
}
