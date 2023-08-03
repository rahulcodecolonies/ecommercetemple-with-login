using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public DateTime? Date { get; set; }
        public string? Gender { get; set; }
        public string? Hobbies { get; set; }
        public string? City { get; set; }
    }
}
