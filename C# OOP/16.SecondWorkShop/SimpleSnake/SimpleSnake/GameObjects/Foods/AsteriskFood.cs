using SimpleSnake.Constants;

namespace SimpleSnake.GameObjects.Foods
{
    public class AsteriskFood : Food
    {
        public AsteriskFood(Cordinate cordinate) 
            : base(GameConstant.Food.AsteriskSymbol, GameConstant.Food.AsteriskPoints, cordinate)
        {
        }
    }
}