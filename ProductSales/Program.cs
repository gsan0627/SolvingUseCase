using System;

namespace ProductSales
{
    class Program
    {
        static void Main(string[] args)
        {

            Product food = new Product(false, false);
            Product drink = new Product(false, false);

            Sale foodSale = new Sale();
            Sale drinkSale = new Sale();
                       
            ProductService productService = new ProductService();
                       
            food.Id = productService.ShowMenu();
            food.UnitPrice = productService.CalculatePriceSelectedFood(food.Id);
            food.Name = productService.GetFoodProduct(food.Id);
            foodSale.Product = food;

            drink.Id = productService.ShowDrink();
            drink.UnitPrice = productService.CalculatePriceSelectedDrink(drink.Id);
            drink.Name = productService.GetDrinkProduct(drink.Id);
            drinkSale.Product = drink;

            SaleService sale = new SaleService(foodSale, drinkSale);
            double total = sale.GetTotalPay();

            string result = total <= 0 ? "El cliente no selecciono ningun producto" : "Total a pagar es :" + total;

            Console.WriteLine(result);   
            Console.ReadKey();
        }
    }
}
