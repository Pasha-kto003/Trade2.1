using System;
using System.Collections.Generic;

#nullable disable

namespace Trade2New.db
{
    public partial class Order
    {
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int OrderId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDeliveryDate { get; set; }
        public string OrderPickupPoint { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
