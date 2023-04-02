


public class Grain: Food
{
    public Grain(string type, float amount, double weight, int size) : base(type, amount, weight, size)
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
}