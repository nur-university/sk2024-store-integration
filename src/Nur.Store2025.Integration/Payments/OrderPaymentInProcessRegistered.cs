using Joseco.Communication.External.Contracts.Message;

namespace Nur.Store2025.Integration.Payments;

public record OrderPaymentInProcessRegistered(Guid OrderId) : IntegrationMessage;