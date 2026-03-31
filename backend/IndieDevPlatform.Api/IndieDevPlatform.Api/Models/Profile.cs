namespace IndieDevPlatform.Api.Models
{
    public class Profile
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string DisplayName { get; set; } = string.Empty;

        public string Bio { get; set; } = string.Empty;

        public string AvatarUrl { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        // Navigation
        public User User { get; set; }
    }
}
