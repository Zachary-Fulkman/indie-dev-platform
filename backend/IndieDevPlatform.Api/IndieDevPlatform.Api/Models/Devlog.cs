namespace IndieDevPlatform.Api.Models
{
    public class Devlog
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public string MediaUrl { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        // Navigation
        public Project Project { get; set; }
    }
}
