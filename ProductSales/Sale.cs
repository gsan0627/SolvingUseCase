using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSales
{
    public class Sale
    {
        private const int DISCOUNT = 15;
        private const int DISCOUNT_AMOUNT = 1000;

        public double GetTotalPay(Product product)
        {
            return (product.UnitPrice * product.Qty);
        }

        public bool GreaterAmountZero(double amountPay)
        {
            return amountPay > 0;
        }

        public bool AmountPayMayApplyDiscount(double amountPay, bool isDiscount)
        {
            return amountPay > DISCOUNT_AMOUNT && isDiscount;
        }

        public double GetDiscount(double amountPay)
        {
            return (amountPay * DISCOUNT) / 100;
        }
    }
}
