


public class Protein: Food
{
    public Protein(string type, float amount, double weight, int size) : base(type, amount, weight, size)
    {

    }

    public override float GetVolume()
    {
        // Fix this later
        return base.GetVolume();
    }

    public override string GetHowMuchNeeded(int age)
    {
        return base.GetHowMuchNeeded(age);
    }

     public override double GetPrice()
    {
        if(!_userSetPrice)
        {
            string lowerType = _type.ToLower();
            if (lowerType == "white beans" || lowerType == "white bean")
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