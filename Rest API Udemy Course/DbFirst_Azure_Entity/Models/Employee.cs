using System;
using System.Collections.Generic;

namespace DbFirst_Azure_Entity.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? City { get; set; }
        public DateTime? WorkDate { get; set; }
        public decimal DailyTypingPage { get; set; }
        public float? Score { get; set; }
        public int? Salary { get; set; }
    }
}
