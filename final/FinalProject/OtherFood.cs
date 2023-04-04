

public class OtherFood: Food
{
    public OtherFood(string type, float amount, double weight, int size) : base(type, amount, weight, size)
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
        if (_price == 45)
        {
            string lowerType = _type.ToLower();
            if (lowerType == "sugar" || lowerType == "granulated sugar" )
            {
                _price = ((59 / 6) * (_weight / 5.6));
            }
            else if (lowerType ==  "macaroni")
            {
                _price = ((39 / 6) * (_weight / 3));
            }
            else if (lowerType == "spagetti bites" || lowerType == "spagetti")
            {
                _price = ((38 / 6) * (_weight / 2.7));
            }
            else if (lowerType == "white flour" || lowerType == "flour")
            {
                _price = ((44 / 6) * (_weight / 4));
            }
            else
            {
                _price = _price / 6;
            }
        }
       
        
        return _price;
    }
}