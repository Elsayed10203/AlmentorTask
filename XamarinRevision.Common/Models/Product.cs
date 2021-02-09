using System;

namespace XamarinRevision.Common.Models
{
    public class Product
    {
        public int productgId { get; set; }
        public string productName { get; set; }
        public string productImage { get; set; }
        public decimal productPrice { get; set; }

        public override string ToString()
        {
            return productName;
        }
    }
}
