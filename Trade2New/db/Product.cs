using System;
using System.Collections.Generic;

#nullable disable

namespace Trade2New.db
{
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public string ProductArticleNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }
        public byte[] ProductPhoto { get; set; }
        public int ManufacturerId { get; set; }
        public decimal ProductCost { get; set; }
        public byte? ProductDiscountAmount { get; set; }
        public int ProductQuantityInStock { get; set; }
        public int StatusId { get; set; }
        public int Id { get; set; }
        public int? MaxDiscount { get; set; }
        public int? SupplierId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual Status Status { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
