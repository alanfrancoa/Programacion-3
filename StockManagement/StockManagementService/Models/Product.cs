using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementService.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public decimal ProductSize { get; set; }
        public string SizeUnit { get; set; }
        public string ProductType { get; set; }
        public long Stock { get; set; }

        public Product(long id, string productName, string productBrand, decimal productSize, string sizeUnit, string productType, long stock)
        {
            Id = id;
            ProductName = productName;
            ProductBrand = productBrand;
            ProductSize = productSize;
            SizeUnit = sizeUnit;
            ProductType = productType;
            Stock = stock;
        }

        public Product()
        {
        }
    }
}
