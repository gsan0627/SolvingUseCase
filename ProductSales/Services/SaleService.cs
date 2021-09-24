using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSales
{
    public class SaleService
    {        
        private const int DISCOUNT = 15;
        private const int DISCOUNT_AMOUNT = 1000;

        private Sale _food;
        private Sale _drink;

        public SaleService(Sale food, Sale drink)
        {
            _food = food;
            _drink = drink;
        }

        public double GetTotalPay()
        {
            return _food.Product.UnitPrice + _drink.Product.UnitPrice;
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
