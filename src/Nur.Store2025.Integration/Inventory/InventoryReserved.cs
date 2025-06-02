using Joseco.Communication.External.Contracts.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nur.Store2025.Integration.Inventory;

public record InventoryReserved : IntegrationMessage
{
    public Guid SourceId { get; set; }
    public string SourceType { get; set; }
}
