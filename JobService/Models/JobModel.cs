namespace JobService.Models
{
    public class JobModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string EmploymentType { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public string Requirements { get; set; } = string.Empty;
        public string Responsibilities { get; set; } = string.Empty;
        public DateTime PostedDate { get; set; }

    }
}