using System;

namespace ShoppingCart.Model
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double DiscountPercentage { get; set; }

        public Product(int productId, string productName, double price, double discountPercentage)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            DiscountPercentage = discountPercentage;
        }

        public double CalculateDiscountedPrice()
        {
            return Price - (Price * DiscountPercentage / 100.0);
        }
        public override string ToString()
        {
            return $"{ProductId} {ProductName} {Price} {DiscountPercentage} {CalculateDiscountedPrice()}";
        }


    }
}
