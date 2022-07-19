
namespace Events
{
    internal class Customer
    {
        public string Name { get; private set; }

        private List<Order> orders = new List<Order>();

        public Customer(string name)
        {
            Name = name;
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
            order.StatusChange += Notify;
        }

        public void Notify(object? sender, EventArgs eventArgs)
        {
            Console.WriteLine("{2}, order status for {0} has been changed to {1}", sender, (sender as Order)?.Status, Name);
        }
    }
}
