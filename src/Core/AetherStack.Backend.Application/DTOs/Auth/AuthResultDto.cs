namespace AetherStack.Backend.Application.DTOs.Auth
{
    public class AuthResultDto
    {
        // Kullanıcı bilgileri
        public int UserId { get; set; }
        public string Email { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string FullName => $"{FirstName} {LastName}";

        // Tokenlar ve süreleri
        public string AccessToken { get; set; } = default!;
        public DateTime AccessTokenExpiresAt { get; set; }
        public string RefreshToken { get; set; } = default!;
        public DateTime RefreshTokenExpiresAt { get; set; }
    }
}
