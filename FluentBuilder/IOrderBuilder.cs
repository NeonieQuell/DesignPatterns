namespace FluentBuilder
{
    public interface IOrderBuilder
    {
        Order Build();

        IOrderBuilder HasOrderId(int orderId);

        IOrderBuilder ShipTo(Action<IAddressBuilder> action);

        IOrderBuilder ShipTo(Address address);
    }

}