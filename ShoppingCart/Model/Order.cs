namespace ShoppingCart.Model
{
    internal class Order
    {
        public int OrderId { get; set; }
        public DateTime TimeStamp { get; set; }
        public List<LineItem> LineItems { get; set; } = new List<LineItem>();

        public Order(int orderId)
        {
            OrderId = orderId;
            TimeStamp = DateTime.Now;
        }

        public double CalculateOrderPrice()
        {
            double totalOrderPrice = 0;

            foreach (var lineItem in LineItems)
            {
                totalOrderPrice += lineItem.CalculateLineItemCost();
            }

            return totalOrderPrice;
        }
        public override string ToString()
        {
            string orderDetails = $"Order Id: {OrderId}\nOrder Date: {TimeStamp}\n\n";
            string lineItemDetails = "LineItemId ProductId Product Name Quantity UnitPrice Discount% UnitCostAfterDiscount TotalLineItemCost\n";

            foreach (var lineItem in LineItems)
            {
                lineItemDetails += lineItem.ToString() + "\n";
            }

            string orderCost = $"Order Cost: {CalculateOrderPrice():F2}\n";

            return orderDetails + lineItemDetails + orderCost;
        }


    }
}
