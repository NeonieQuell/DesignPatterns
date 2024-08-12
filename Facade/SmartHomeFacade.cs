namespace Facade
{
    public class SmartHomeFacade : ISmartHomeFacade
    {
        private readonly ISmartLighting smartLighting;
        private readonly ISecuritySystem securitySystem;

        public SmartHomeFacade(ISmartLighting smartLighting, ISecuritySystem securitySystem)
        {
            this.smartLighting = smartLighting;
            this.securitySystem = securitySystem;
        }

        public void EveningSetup()
        {
            this.smartLighting.TurnOff();
            this.securitySystem.Activate();
        }

        public void MorningSetup()
        {
            this.smartLighting.TurnOn();
            this.smartLighting.Dim(50);
            this.securitySystem.Deactivate();
        }
    }
}