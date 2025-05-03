using Joseco.Communication.External.Contracts.Message;

namespace Nur.Store2025.Integration.Identity;

public record UserCreated : IntegrationMessage
{
    public Guid UserId { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }

    public UserCreated(Guid userId, string fullName, string email, string? correlationId = null, string? source = null)
        : base(correlationId, source)
    {
        UserId = userId;
        FullName = fullName;
        Email = email;
    }

}
