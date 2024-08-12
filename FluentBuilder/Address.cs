namespace FluentBuilder
{
    public class Address
    {
        public required string Street { get; set; }

        public required string City { get; set; }

        public required string Country { get; set; }

        public override string ToString() => $"Address [Street={Street}, City={City}, Country={Country}]";
    }
}