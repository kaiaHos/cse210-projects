


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