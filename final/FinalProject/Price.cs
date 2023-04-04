


public class Price
{
    private double _total = 0;

    public Price(List<Food> foods)
    {
        foreach (Food food in foods)
        {
            //Console.WriteLine(food);
            //Console.WriteLine(food.GetPrice());
            _total += (food.GetPrice() * food.GetAmount());
        }
    }
    public double GetTotal()
    {
        return _total;
    }
}