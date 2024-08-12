using System.Text;

namespace Decorator
{
    public class ITStudentDecorator : StudentDecorator
    {
        public ITStudentDecorator(IStudent student) : base(student)
        {

        }

        public override string GetSkill()
        {
            StringBuilder sb = new();
            sb.AppendLine(base.GetSkill());
            sb.AppendLine("Can perform basic computer related tasks.");
            return sb.ToString();
        }
    }
}