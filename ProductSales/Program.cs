using System;

namespace ProductSales
{
    class Program
    {
        static void Main(string[] args)
        {

            //Cliente solicito un cambio en el programa que realice lo siguiente
            // Que pueda agregar el impuesto pero que sea el mismo usuario que pueda decir si el producto se le aplica impuesto 
            // Que sea el mismo usuario que pueda decir si el producto se le aplica descuento



            Product product = new Product(false, false);
            Sale sale = new Sale();

            Console.WriteLine("Introduce el producto que deseas facturar");
            product.Name = Console.ReadLine();

            Console.WriteLine("Introduce la cantidad del producto a facturar");
            product.Qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el precio unitario del producto a facturar");
            product.UnitPrice = Convert.ToDouble(Console.ReadLine());

            double totalPay = sale.GetTotalPay(product);

            string showSaleInformation = string.Format("El {0}: {1} x {2} = {3}",
                product.Name, product.Qty, product.UnitPrice, totalPay);

            if (sale.GreaterAmountZero(totalPay) == false)
            {
                Console.WriteLine("El monto debe ser mayor a cero (0)");
            }
            else
            {
                if (sale.AmountPayMayApplyDiscount(totalPay, product.IsDiscount))
                {
                    product.Discount = sale.GetDiscount(totalPay);
                    totalPay -= product.Discount;
                }
                Console.WriteLine(showSaleInformation);
                Console.WriteLine("Descuento: " + product.Discount);
                Console.WriteLine("El total a pagar es: " + totalPay);
            }

            Console.ReadKey();
        }
    }
}
