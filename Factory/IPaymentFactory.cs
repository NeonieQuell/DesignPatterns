namespace Factory
{
    public interface IPaymentFactory
    {
        IPayment GetPayment(PaymentOption payment);
    }
}