

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

    public override string GetHowMuchNeeded(int age)
    {
        if( _type.ToLower() == "oil")
        {
            _needed = "10 quarts";
        }
        else
        {
            // determines main amount for an adult
            int adultPortion = 60;
            if (_type.ToLower() == "macaroni" || _type.ToLower() == "spaggetti" || _type.ToLower() == "flour" || _type.ToLower() == "white flour")
            {
                adultPortion = 400;
            }
            else if (_type.ToLower() == "salt")
            {
                adultPortion = 8;
            }
          
            // determines how much based off age
            if (age <= 3)
            {
                _needed = $"{adultPortion * .5} pounds";
            }
            if (age <= 6)
            {
                _needed = $"{60 * .7} pounds";
            }
            if (age <= 10)
            {
                _needed = $"{60 * .9} pounds";
            }
            if (age >= 11)
            {
                _needed = $"{60 * 1} pounds";
            }
            
        }
        return _needed;
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