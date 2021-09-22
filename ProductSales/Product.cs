using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSales
{
    public class Product
    {
        public Product(bool isDiscount, bool isTax)
        {
            IsDiscount = isDiscount;
            IsTax = isTax;
        }
        public int Qty;
        public string Name;
        public double UnitPrice;
        public double Discount;
        public bool IsDiscount;
        public double Tax;
        public bool IsTax;
    }
}
