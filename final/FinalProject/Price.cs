


public class Price
{
    private double _total = 0;

    public Price(List<Food> foods)
    {
        foreach (Food food in foods)
        {
            _total += food.GetPrice();
        }
    }
    public double GetTotal()
    {
        return _total;
    }
}