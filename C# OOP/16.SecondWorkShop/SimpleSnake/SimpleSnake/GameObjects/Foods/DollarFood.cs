using SimpleSnake.Constants;

namespace SimpleSnake.GameObjects.Foods
{
    public class DollarFood : Food
    {
        public DollarFood(Cordinate cordinate) 
            : base(GameConstant.Food.DollarSymbol, GameConstant.Food.DollarPoints, cordinate)
        {
        }
    }
}