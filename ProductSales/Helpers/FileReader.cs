using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProductSales.Helpers
{
    public class FileReader
    {
        public string GetFileAsString(string filePath)
        {
            if (!File.Exists(filePath))
                return string.Empty;

            return File.ReadAllText(filePath);
        }
    }
}
