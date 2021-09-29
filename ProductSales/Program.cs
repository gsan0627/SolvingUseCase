using System;

namespace ProductSales
{
    class Program
    {
        static void Main(string[] args)
        {
            string press;
            double total = 0.0;

            ProductService productService = new ProductService();
            SaleService saleService = new SaleService();
          
            do
            {
                Console.Clear();
                var products = productService.GetAll();
                int count = 0;
                int length = products.Length - 1;

                Console.WriteLine("Seleccione el producto");
                while (length >= count)
                {                    
                    Console.WriteLine("{0} - {1}", productService.ShowProductQuantity(count), 
                        productService.GetProductAsString(products[count]));
                    count++;
                }

                int selected = Convert.ToInt32(Console.ReadLine());
                Product productSelected = products[selected - 1];

                total += productSelected.UnitPrice;
                Console.WriteLine("Deseas agregar otro producto a tu lista, presiona S para continuar o cualquier tecla para salir");
                press = Console.ReadLine();

            } while (press == "S" || press == "s");

            if (saleService.GreaterTotalZero(total))
            {
                Console.WriteLine("El total a pagar es: " + total);
            }
            else
            {
                Console.WriteLine("El cliente no selecciono ningun producto");
            }

            Console.ReadKey();
        }
    }
}