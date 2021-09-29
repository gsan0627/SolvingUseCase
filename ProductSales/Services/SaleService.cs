using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSales
{
    public class SaleService
    {       
        public bool GreaterTotalZero(double amountPay)
        {
            return amountPay > 0;
        }
    }
}
