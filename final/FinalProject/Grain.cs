


public class Grain: Food
{
    public Grain(string type, float amount, double weight, int size) : base(type, amount, weight, size)
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
            _needed = $"{400 * .5} pounds";
        }
        if (age <= 6)
        {
            _needed = $"{400 * .7} pounds";
        }
        if (age <= 10)
        {
            _needed = $"{400 * .9} pounds";
        }
        if (age >= 11)
        {
            _needed = $"{400 * 1} pounds";
        }
        return _needed;
    }
    public override double GetPrice()
    {
        if(!_userSetPrice)
        {
            string lowerType = _type.ToLower();
            if (lowerType == "hard red wheat" || lowerType == "red wheat")
            {
                _price = ((47 / 6) * (_weight / 5.5));
            }
            else if (lowerType == "hard white wheat" || lowerType =="white wheat")
            {
                _price = ((46 / 6) * (_weight / 5.5));
            } 
            else if (lowerType == "quick oats" ) 
            {
                _price = ((52 / 6) * (_weight / 2.4));
            }
            else if (lowerType == "regular oats" || lowerType == "oats")
            {
                _price = ((46 / 6) * (_weight / 7.8));
            }
            else if (lowerType == "white rice" || lowerType == "rice")
            {
                _price = ((54 / 6) * (_weight / 5.4));
            }
            else
            {
                _price = (_price / 6);
            }
        }
        
        
        return _price;
    }
}