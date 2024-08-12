namespace FluentBuilder
{
    public class AddressBuilder : IAddressBuilder
    {
        private string street = default!;
        private string country = default!;
        private string city = default!;
        private Address address;

        public AddressBuilder(Address address)
        {
            this.address = address;
        }

        public Address Build()
        {
            if (string.IsNullOrWhiteSpace(street) ||
                string.IsNullOrWhiteSpace(city) ||
                string.IsNullOrWhiteSpace(country))
            {
                throw new ArgumentException("One or more required fields are not set");
            }

            this.address.Street = this.street;
            this.address.City = this.city;
            this.address.Country = this.country;
            return this.address;
        }

        public IAddressBuilder City(string city)
        {
            this.city = city;
            return this;
        }

        public IAddressBuilder Country(string country)
        {
            this.country = country;
            return this;
        }

        public IAddressBuilder Street(string street)
        {
            this.street = street;
            return this;
        }
    }
}