namespace Proxy
{
    public class ServiceRepository : IServiceRepository
    {
        public void GetObject(int objectId)
        {
            Console.WriteLine($"ObjectId: {objectId}, Name: Name, IsCached: False");
        }
    }
}