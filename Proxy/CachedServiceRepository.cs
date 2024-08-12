using Microsoft.Extensions.DependencyInjection;

namespace Proxy
{
    public class CachedServiceRepository : IServiceRepository
    {
        private IServiceRepository serviceRepository;
        private bool isCached;

        public CachedServiceRepository([FromKeyedServices("Concrete")] IServiceRepository serviceRepository)
        {
            this.serviceRepository = serviceRepository;
        }

        public void GetObject(int objectId)
        {
            if (this.isCached)
            {
                Console.WriteLine($"ObjectId: {objectId}, Name: Name, IsCached: True");
                return;
            }
            this.serviceRepository.GetObject(objectId);

            // Imitate caching logic

            this.isCached = true;
        }
    }
}