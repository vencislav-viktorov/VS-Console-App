using SimpleSnake.Constants;

namespace SimpleSnake.GameObjects.Foods
{
    public class HashFood : Food
    {
        public HashFood(Cordinate cordinate) 
            : base(GameConstant.Food.HashSymbol, GameConstant.Food.HashPoints, cordinate)
        {
        }
    }
}