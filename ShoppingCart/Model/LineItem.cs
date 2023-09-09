using System;

namespace ShoppingCart.Model
{
    internal class LineItem
    {
        public int LineItemId { get; set; }
        public int Quantity { get; set; }
        public Product? Product { get; set; }

        public LineItem(int lineItemId, int quantity)
        {
            LineItemId = lineItemId;
            Quantity = quantity;
        }

        public double CalculateLineItemCost()
        {
            if (Product != null)
            {
                return Quantity * Product.CalculateDiscountedPrice();
            }
            return 0;
        }
        public override string ToString()
        {
            //return $"{LineItemId,-11} {Product?.ProductId,-11} {Product?.ProductName,-12} {Quantity,-9} {Product?.Price,-11:F2} {Product?.DiscountPercentage,-11:F2} {Product?.CalculateDiscountedPrice():F2} {CalculateLineItemCost():F2}";
            return $"   "+$"{LineItemId}"+"     " +$"{Product?.ProductId}"+"         "+$"{Product?.ProductName}"+"   "+$"{Quantity}"+"           "+$"{Product?.Price}"+"        "+$"{Product?.DiscountPercentage}"+"         "+$"{Product?.CalculateDiscountedPrice()}"+"                          "+$"{CalculateLineItemCost()}";
        }


    }
}
