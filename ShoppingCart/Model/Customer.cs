using System.Text;

namespace ShoppingCart.Model
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        public Customer(int customerId, string customerName)
        {
            CustomerId = customerId;
            CustomerName = customerName;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Customer Id: {CustomerId}");
            sb.AppendLine($"Customer Name: {CustomerName}");
            sb.AppendLine($"Order Count: {Orders.Count}");
            sb.AppendLine();

            foreach (var order in Orders)
            {
                sb.AppendLine($"{order}");
            }

            return sb.ToString();
        }
    }
}
