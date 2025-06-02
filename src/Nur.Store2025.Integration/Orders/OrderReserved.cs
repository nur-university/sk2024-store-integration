using Joseco.Communication.External.Contracts.Message;

namespace Nur.Store2025.Integration.Orders;

public record OrderReserved(Guid OrderId, decimal TotalAmount) : IntegrationMessage;
