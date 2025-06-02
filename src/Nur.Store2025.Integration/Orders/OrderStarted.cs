using Joseco.Communication.External.Contracts.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nur.Store2025.Integration.Orders;

public record OrderStarted : IntegrationMessage
{
    public Guid OrderId { get; set; }

    public ICollection<OrderItemStarted> Items { get; set; }

    public OrderStarted(Guid orderId, ICollection<OrderItemStarted> items) : base()
    {
        OrderId = orderId;
        Items = items;
    }
    public OrderStarted() : base()
    {
        Items = new List<OrderItemStarted>();
    }
}

public record OrderItemStarted
{
    public Guid ProductId { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}