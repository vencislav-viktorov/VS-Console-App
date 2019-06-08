namespace WildFarm
{
    public class FoodFactory
    {
        public static Food Create(params string[] foodArgs)
        {
            var type = foodArgs[0];
            var quantity = int.Parse(foodArgs[1]);

            if (type == nameof(Vegetable))
            {
                return new Vegetable(quantity);
            }

            else if (type == nameof(Fruit))
            {
                return new Fruit(quantity);
            }

            else if (type == nameof(Seeds))
            {
                return new Seeds(quantity);
            }

            else if (type == nameof(Meat))
            {
                return new Meat(quantity);
            }

            return null;
        }
    }
}