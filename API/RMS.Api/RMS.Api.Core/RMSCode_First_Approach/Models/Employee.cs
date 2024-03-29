﻿using System;
using System.Collections.Generic;

namespace RMS.Api.Core.Models
{
    public partial class Employee
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Dob { get; set; }
        public string? Email { get; set; }
    }
}
