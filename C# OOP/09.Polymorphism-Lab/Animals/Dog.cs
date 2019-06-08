namespace Animals
{
    using System.Text;

    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) 
            : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ExplainSelf());
            sb.Append("DJAAF");

            return sb.ToString();
        }
    }
}