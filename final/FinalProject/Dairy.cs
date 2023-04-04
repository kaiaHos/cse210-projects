


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

    public override int GetHowMuchNeeded(int age)
    {
        // Fix this later
        return base.GetHowMuchNeeded(age);
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