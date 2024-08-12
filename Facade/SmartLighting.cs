namespace Facade
{
    public class SmartLighting : ISmartLighting
    {
        public void Dim(int dimLevel)
        {
            Console.WriteLine($"Lights dimmed at: {dimLevel}");
        }

        public void TurnOff()
        {
            Console.WriteLine("Lights turned off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Lights turned on");
        }
    }

}