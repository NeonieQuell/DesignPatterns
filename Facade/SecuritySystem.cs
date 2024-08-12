namespace Facade
{
    public class SecuritySystem : ISecuritySystem
    {
        public void Activate()
        {
            Console.WriteLine("Security system activated");
        }

        public void Deactivate()
        {
            Console.WriteLine("Security system deactivated");
        }
    }
}