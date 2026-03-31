namespace IndieDevPlatform.Api.Models
{
    public class Project
    {
        public int Id { get; set; }

        public int OwnerId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string HeroImageUrl { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        // Navigation
        public User Owner { get; set; }

        public List<Devlog> Devlogs { get; set; }

        public List<CollaborationRequest> CollaborationRequests { get; set; }
    }
}
