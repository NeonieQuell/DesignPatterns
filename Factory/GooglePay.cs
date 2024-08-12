namespace Factory
{
    public class GooglePay : IPayment
    {
        public void Pay()
        {
            Console.WriteLine($"Payment successful using Google Pay.");
        }
    }
}