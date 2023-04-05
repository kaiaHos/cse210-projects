


public class Water: Food
{
    public Water(string type, float amount, double weight, int size) : base(type, amount, weight, size)
    {

    }

    public override float GetVolume()
    {
        // Fix this later
        return base.GetVolume();
    }

    public override string GetHowMuchNeeded(int age)
    {
        if (age <= 3)
        {
            _needed = $"{14 * .5} gallons";
        }
        if (age <= 6)
        {
            _needed = $"{14 * .7} gallons";
        }
        if (age <= 10)
        {
            _needed = $"{14 * .9} gallons";
        }
        if (age >= 11)
        {
            _needed = $"{14 * 1} gallons";
        }
        return _needed;
    }

    public override double GetPrice()
    {
        if(!_userSetPrice)
        {
            _price = 0.0;
        }
        return _price;
    }
}