using System;
using NServiceBus;

namespace Order.Message
{
    public class ProcessOrderCommand : ICommand
    {
        public string OrderId { get; set; }

        public DateTime OrderDateTime { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public string ShippingAddress { get; set; }
    }
}
