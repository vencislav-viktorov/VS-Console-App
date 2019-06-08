namespace Animals
{
    using System.Text;

    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood) 
            : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ExplainSelf());
            sb.Append("MEEOW");

            return sb.ToString();
        }
    }
}