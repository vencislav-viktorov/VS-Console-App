namespace WildFarm
{
    public class AnimalFactory
    {
        public static Animal Create(params string[] animalArgs)
        {
            var type = animalArgs[0];
            var name = animalArgs[1];
            var weight = double.Parse(animalArgs[2]);

            if (type == nameof(Hen))
            {
                var wingSize = double.Parse(animalArgs[3]);

                return new Hen(name, weight, wingSize);
            }

            else if (type == nameof(Owl))
            {
                var wingSize = double.Parse(animalArgs[3]);

                return new Owl(name, weight, wingSize);
            }

            else if (type == nameof(Mouse))
            {
                var livingRegion = animalArgs[3];

                return new Mouse(name, weight, livingRegion);
            }

            else if (type == nameof(Dog))
            {
                var livingRegion = animalArgs[3];

                return new Dog(name, weight, livingRegion);
            }

            else if (type == nameof(Cat))
            {
                var livingRegion = animalArgs[3];
                var breed = animalArgs[4];

                return new Cat(name, weight, livingRegion, breed);
            }

            else if (type == nameof(Tiger))
            {
                var livingRegion = animalArgs[3];
                var breed = animalArgs[4];

                return new Tiger(name, weight, livingRegion, breed);
            }

            return null;
        }
    }
}