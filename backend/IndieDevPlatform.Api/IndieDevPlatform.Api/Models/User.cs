using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IndieDevPlatform.Api.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        // Navigation
        public Profile Profile { get; set; }
    }
}
