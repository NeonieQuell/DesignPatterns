namespace FluentBuilder
{
    public class OrderBuilder : IOrderBuilder
    {
        private int orderId;
        private Order order;
        private Address? address;
        private IAddressBuilder addressBuilder;

        public OrderBuilder(Order order, IAddressBuilder addressBuilder)
        {
            this.order = order;
            this.addressBuilder = addressBuilder;
        }

        public Order Build()
        {
            if (this.orderId <= 0)
            {
                throw new ArgumentOutOfRangeException("OrderId cannot be less than or equal to 0");
            }

            this.order.OrderId = this.orderId;
            this.order.CreateDate = DateTime.Now;
            this.order.Address = this.address ?? this.addressBuilder.Build();
            return this.order;
        }

        public IOrderBuilder HasOrderId(int orderId)
        {
            this.orderId = orderId;
            return this;
        }

        public IOrderBuilder ShipTo(Action<IAddressBuilder> action)
        {
            action(this.addressBuilder);
            return this;
        }

        public IOrderBuilder ShipTo(Address address)
        {
            this.address = address;
            return this;
        }
    }
}