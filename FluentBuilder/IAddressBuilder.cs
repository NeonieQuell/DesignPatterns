namespace FluentBuilder
{
    public interface IAddressBuilder
    {
        Address Build();

        IAddressBuilder Street(string street);

        IAddressBuilder City(string city);

        IAddressBuilder Country(string country);
    }
}