﻿using System;
using System.Collections.Generic;

namespace WebApplication5.Models
{
    public partial class UserLogin
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
