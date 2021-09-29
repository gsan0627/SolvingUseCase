using Newtonsoft.Json;
using ProductSales.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSales
{
    public class ProductService
    {

        private FileReader fileReader = new FileReader();

        public Product[] GetAll()
        {
            string json = fileReader.GetFileAsString(Constant.GetProductPath);
            var result = JsonConvert.DeserializeObject<Product[]>(json);
            return result;
        }

        public string GetProductAsString(Product product)
        {
            return string.Format("{0} : ${1}", product.Name, product.UnitPrice);
        }

        public string ShowProductQuantity(int count)
        {
            return ((count + 1) > 9) ? (count + 1).ToString() : "0" + (count + 1);
        }

    }
}
