namespace Factory
{
    public class PaymentFactory : IPaymentFactory
    {
        public IPayment GetPayment(PaymentOption payment)
        {
            return payment switch
            {
                PaymentOption.ApplePay => new ApplePay(),
                PaymentOption.GooglePay => new GooglePay(),
                _ => throw new NotSupportedException("This payment option is currently not supported"),
            };
        }
    }
}