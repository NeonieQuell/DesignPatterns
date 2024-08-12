namespace Decorator
{
    /// <summary>
    /// Base decorator
    /// </summary>
    public class StudentDecorator : IStudent
    {
        private readonly IStudent student;

        public StudentDecorator(IStudent student)
        {
            this.student = student;
        }

        public virtual string GetSkill() => this.student.GetSkill();
    }
}