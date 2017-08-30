using System;

namespace _04.Fruit_or_Vegetable
{
    class Fruit_or_Vegetable
    {
        static void Main()
        {
            string pro = Console.ReadLine();

            if (pro == "banana" || pro == "apple" || pro == "kiwi" ||
                pro == "cherry" || pro == "lemon" || pro == "grapes")
            {
                Console.WriteLine("fruit");
            }

            else if (pro == "tomato" || pro == "cucumber" ||
            pro == "pepper" || pro == "carrot")
            {
                Console.WriteLine("vegetable");
            }

            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
