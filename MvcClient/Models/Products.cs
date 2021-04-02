using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcClient.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int QtyInStock { get; set; }
        public string Description { get; set; }
        public string Supplier { get; set; }
    }
}