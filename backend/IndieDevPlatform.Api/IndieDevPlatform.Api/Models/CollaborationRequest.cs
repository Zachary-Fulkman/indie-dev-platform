namespace IndieDevPlatform.Api.Models
{
    public class CollaborationRequest
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public int UserId { get; set; }

        public string Role { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        // Navigation
        public Project Project { get; set; }

        public User User { get; set; }
    }
}
