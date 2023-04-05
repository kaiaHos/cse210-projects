


public class Dairy: Food
{
    public Dairy(string type, float amount, double weight, int size) : base(type, amount, weight, size)
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
            _needed = $"{16 * .5} pounds";
        }
        if (age <= 6)
        {
            _needed = $"{16 * .7} pounds";
        }
        if (age <= 10)
        {
            _needed = $"{16 * .9} pounds";
        }
        if (age >= 11)
        {
            _needed = $"{16 * 1} pounds";
        }
        return _needed;
    }

    public override double GetPrice()
    {
        if(_price == 45)
        {
            string lowerType = _type.ToLower();
            if (lowerType == "milk" || lowerType == "dry milk" || lowerType == "lowfat dry milk" || lowerType == "lowfat milk")
            {
                _price = ((95 / 12) * (_weight / 1));
            }
            else
            {
                _price = _price / 6;
            }
        }
       
        
        return _price;
    }

    
}