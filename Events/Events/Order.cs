
namespace Events
{
    internal class Order
    {
        public enum OrderStatus { Unconfirmed, Confirmed, Shipped, Delivered };

        public OrderStatus Status { get; private set; }

        private OrderStatus oldStatus;

        public string Commodity { get; private set; }

        public event EventHandler? StatusChange;
        // In .NET event is declared as this: 
        // - it takes two parametres, first is object which invoked the event and second are paramss of event
        // public delegate void EventHandler(object sender, EventArgs e);

        public Order(string commodity)
        {
            Status = OrderStatus.Unconfirmed;
            oldStatus = Status;
            Commodity = commodity;
        }

        // Public events are not inherited and child can't access it, that is why it is common practice, to implement
        // protected method which invokes the Event itself
        public void OnStatusChange(EventArgs e)
        {
            if (Status != oldStatus)
            {
                // 1st) Solution
                //if (StatusChange != null)
                //    StatusChange(this, e);

                // 2nd) Solution (BETTER), it checks if StatusChange is not null and then calls event with arguments
                StatusChange?.Invoke(this, e);
            }
        }

        public void ChangeStatus(OrderStatus status)
        {
            oldStatus = Status;
            Status = status;
            //OnStatusChange(EventArgs.Empty);
            StatusChange?.Invoke(this, new EventArgs());
        }

        public override string ToString()
        {
            return "Order " + Commodity;
        }
    }
}
