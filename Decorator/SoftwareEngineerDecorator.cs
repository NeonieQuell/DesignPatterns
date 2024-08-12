namespace Decorator
{
    public class SoftwareEngineerDecorator : ITStudentDecorator
    {
        public SoftwareEngineerDecorator(IStudent student) : base(student)
        {

        }

        public override string GetSkill() => @$"{base.GetSkill()}Can build applications.";
    }
}