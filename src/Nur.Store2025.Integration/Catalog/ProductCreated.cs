using Joseco.Communication.External.Contracts.Message;

namespace Nur.Store2025.Integration.Catalog;

public record ProductCreated : IntegrationMessage
{
    public Guid ProductId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ProductCreated(Guid productId, string name, string description, string? correlationId = null, string? source = null)
        :base(correlationId, source)
    {
        ProductId = productId;
        Name = name;
        Description = description;
    }
}
