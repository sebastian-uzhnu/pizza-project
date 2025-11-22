namespace Pizzeria;

public struct Pizza
{
    public string Name;
    public double Value;
    public double Weight;
    public int Calories;

    public Pizza(string name, double price, double weight, int calories)
    {
        Name = name;
        Value = price;
        Weight = weight;
        Calories = calories;
    }
}
