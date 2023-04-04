



public abstract class Food
{
    protected string _type = "";
    protected string _description = "";
    protected float _amount;
    protected double _weight; // it will be in lb.
    protected int _size; // ?
    protected double _price = 45; // in dollars

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
    
    public double GetPrice()
    {
        return _price;
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
        float volume = _size * (float)2.00;
        return volume;
    }

    public virtual int GetHowMuchNeeded(int age)
    {
        return 10;
    }
}