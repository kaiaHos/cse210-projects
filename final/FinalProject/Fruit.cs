


public class Fruit: Food
{
    public Fruit(string type, float amount, double weight, int size) : base(type, amount, weight, size)
    {

    }

    public override float GetVolume()
    {
        // Fix this later
        return base.GetVolume();
    }

    public override string GetHowMuchNeeded(int age)
    {
        // Fix this later
        return base.GetHowMuchNeeded(age);
    }

     public override double GetPrice()
    {
        if (_price == 45)
        {
            string lowerType = _type.ToLower();
            if (lowerType == "apple slices" || lowerType == "apple" || lowerType == "apples")
            {
                _price = ((66 / 6) * (_weight / 1));
            }
            else
            {
                _price = _price / 6;
            }
        }
        
        
        return _price;
    }
}