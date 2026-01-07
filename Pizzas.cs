namespace Pizzeria;

public struct PizzaNew
{
    public string Name;
    public double Value;
    public double Weight;
    public int Calories;

    public PizzaNew(string name, double price, double weight, int calories)
    {
        Name = name;
        Value = price;
        Weight = weight;
        Calories = calories;
    }
}
