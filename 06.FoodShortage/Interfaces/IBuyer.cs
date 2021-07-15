namespace _06.FoodShortage.Interfaces
{
    public interface IBuyer : IName
    {
        int Food { get; }

        void BuyFood();
    }
}