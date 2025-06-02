using Joseco.Communication.External.Contracts.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nur.Store2025.Integration.Inventory;

public record InventoryReservationFailed : IntegrationMessage
{
    public Guid OrderId { get; set; }
    public string Reason { get; set; }
}
