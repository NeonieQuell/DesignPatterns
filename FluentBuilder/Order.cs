namespace FluentBuilder
{
    public class Order
    {
        public required int OrderId { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

        public required Address Address { get; set; } = null!;

        public override string ToString() => $"Order [OrderId={OrderId}, CreateDate={CreateDate}, Address={Address}]";
    }
}