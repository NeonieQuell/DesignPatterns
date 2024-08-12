namespace Factory
{
    public class ApplePay : IPayment
    {
        public void Pay()
        {
            Console.WriteLine($"Payment successful using Apple Pay.");
        }
    }
}