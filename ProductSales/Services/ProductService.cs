using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSales
{
    public class ProductService
    {

        public int ShowMenu()
        {
            Console.WriteLine("1. Plato del dia: " + Constant.PLATO_DIA);
            Console.WriteLine("2. Pica pollo: " + Constant.PICA_POLLO);
            Console.WriteLine("3. Guineo con cebolla y salami: " + Constant.GUINEO_CON_SALAMI);
            Console.WriteLine("4. Chimi: " + Constant.CHIMI);
            Console.WriteLine("5. Hotdog: " + Constant.HOTDOG);
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }

        public string GetFoodProduct(int productId)
        {
            string producto = "";
            switch (productId)
            {
                case 1:
                    producto = "Plato del dia";
                    break;

                case 2:
                    producto = "Pica Pollo";
                    break;

                case 3:
                    producto = "Guineo con cebolla y Salami";
                    break;

                case 4:
                    producto = "Chimi";
                    break;

                case 5:
                    producto = "Hotdog";
                    break;
            }

            return producto;
        }

        public int ShowDrink()
        {
            Console.WriteLine("1. Refrescos");
            Console.WriteLine("2. Jugo Natural");
            Console.WriteLine("3. Agua");
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }

        public string GetDrinkProduct(int productId)
        {
            string producto = "";
            switch (productId)
            {
                case 1:
                    producto = "Plato del dia";
                    break;

                case 2:
                    producto = "Pica Pollo";
                    break;

                case 3:
                    producto = "Guineo con cebolla y Salami";
                    break;

                case 4:
                    producto = "Chimi";
                    break;

                case 5:
                    producto = "Hotdog";
                    break;
            }

            return producto;
        }

        public double CalculatePriceSelectedFood(int selectedFood)
        {
            double price = 0.0;
            switch (selectedFood)
            {
                case 1:
                    price = Constant.PLATO_DIA;
                    break;

                case 2:
                    price = Constant.PICA_POLLO;
                    break;

                case 3:
                    price = Constant.GUINEO_CON_SALAMI;
                    break;

                case 4:
                    price = Constant.CHIMI;
                    break;

                case 5:
                    price = Constant.HOTDOG;
                    break;
            }

            return price;
        }

        public double CalculatePriceSelectedDrink(int selectedDrink)
        {
            double price = 0.0;
            switch (selectedDrink)
            {
                case 1:
                    price = Constant.REFRESCO;
                    break;

                case 2:
                    price = Constant.JUGO_NATURAL;
                    break;

                case 3:
                    price = Constant.AGUA;
                    break;
            }

            return price;
        }


    }
}
