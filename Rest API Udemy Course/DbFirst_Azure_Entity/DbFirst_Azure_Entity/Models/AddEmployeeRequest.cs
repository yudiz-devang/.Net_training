namespace DbFirst_Azure_Entity.Models
{
    public class AddEmployeeRequest
    {
        public string Name { get; set; }
        public string? City { get; set; }
        public decimal DailyTypingPage { get; set; }
        public float? Score { get; set; }
        public int? Salary { get; set; }
    }
}
