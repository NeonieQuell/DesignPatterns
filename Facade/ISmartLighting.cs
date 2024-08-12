namespace Facade
{
    public interface ISmartLighting
    {
        void TurnOn();

        void TurnOff();

        void Dim(int dimLevel);
    }
}