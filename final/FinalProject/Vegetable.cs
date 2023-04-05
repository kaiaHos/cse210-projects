


public class Veg: Food
{
    public Veg(string type, float amount, double weight, int size) : base(type, amount, weight, size)
    {

    }

    public override float GetVolume()
    {
        // Fix this later
        return base.GetVolume();
    }

    public override string GetHowMuchNeeded(int age)
    {
        if (_type.ToLower() == "corn")
        {
            if (age <= 3)
            {
                _needed = $"{60 * .5} pounds";
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
        else
        {
            _needed = base.GetHowMuchNeeded(age);
        }

        return _needed;
    }

    public override double GetPrice()
    {
        if(_price == 45)
        {
            string lowerType = _type.ToLower();
            if (lowerType == "carrot" || lowerType == "carrots")
            {
                _price = ((62 / 6) * (_weight / 2.1));
            }
            else if (lowerType == "dry onions" || lowerType =="onions" || lowerType == "dry onion" || lowerType == "onion")
            {
                _price = ((59 / 6) * (_weight / 2.1));
            } 
            else if (lowerType == "potato flakes" || lowerType == "potato" || lowerType == "potatoes") 
            {
                _price = ((52 / 6) * (_weight / 1.8));
            }
            else if (lowerType == "white beans" || lowerType == "white bean")
            {
                _price = ((56 / 6) * (_weight / 5.3));
            }
            else if (lowerType == "black beans" || lowerType == "black bean")
            {
                _price = ((63 / 6) * (_weight / 5.5));
            }
            else if (lowerType == "pinto beans" || lowerType == "pinto bean")
            {
                _price = ((60 / 6) * (_weight / 5.2));
            }
            else
            {
                _price = _price / 6;
            }
        }
        
        
        return _price;
    }
}