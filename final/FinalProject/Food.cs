



public abstract class Food
{
    protected string _type = "";
    protected string _description = "";
    protected float _amount;
    protected double _weight; // it will be in lb.
    protected int _size = 7; // ?
    protected double _price = 45; // in dollars
    protected string _needed = "";
    protected Boolean _userSetPrice = false;

    public Food(string type, float amount, double weight, int size)
    {
        _type = type;
        //_description = descript;
        _amount = amount;
        _weight = weight;
        _size = size;
    }

    public void SetFoodType(string foodType)
    {
        _type = foodType;
    }

    public void SetAmount(float amount)
    {
        _amount = amount;
    }

    public void SetWeight(double weight)
    {
        _weight = weight;
    }

    public void SetPrice(double price)
    {
        _price = price;
        _userSetPrice = true;

    }

    public float GetAmount()
    {
        return _amount;
    }

    public string GetFoodType()
    {
        return _type ;
    }

    public string GetFoodInfo()
    {
        return _type + " (" + _weight + "lbs) - quanity " + _amount;
    }

    public virtual float GetVolume()
    {
        float volume = _size * _size * _size;
        return volume;
    }

    public virtual string GetHowMuchNeeded(int age)
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
        return _needed;
    }

     public virtual double GetPrice()
    {
        return _price;
    }

}