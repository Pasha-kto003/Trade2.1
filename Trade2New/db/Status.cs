using System;
using System.Collections.Generic;

#nullable disable

namespace Trade2New.db
{
    public partial class Status
    {
        public Status()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
