
public class Space{

    private double _volume = 0;
    public Space(List<Food> foods)
    {
        foreach (Food food in foods)
        {
            _volume += food.GetVolume();
        }
    }
    public double GetTotalSpace()
    {
        return _volume;
    }
}