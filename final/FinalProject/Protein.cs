


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