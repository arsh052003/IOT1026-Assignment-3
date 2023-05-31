namespace Assignment;

class Pack
{
    private InventoryItem[] _items; // You can use another data structure here if you prefer.
    // You may need another private member variable if you use an array data structure.

    public Pack(int maxCount, float maxVolume, float maxWeight)
    {
        throw new NotImplementedException();
    }

    public bool Add(InventoryItem item)
    {
        throw new NotImplementedException();
    }

    // Implement this class
    public override string ToString()
    {
        throw new NotImplementedException();
    }
}

// Come back to this once we learn about abstract classes.
public class InventoryItem
{
    private readonly float _volume;
    private readonly float _weight;

    public InventoryItem(float weight, float volume)
    {
        if (volume <= 0f || weight <= 0f)
        {
            throw new ArgumentOutOfRangeException($"An item can't have {volume} volume or {weight} weight");
        }
        _volume = volume;
        _weight = weight;
    }

    // Getters
    public float GetVolume()
    {
        return _volume;
    }

    public float GetWeight()
    {
        return _weight;
    }
}

// Implement these classes - each inherits from InventoryItem
// 1 line of code each - call base class constructor with appropriate arguments
class Arrow : InventoryItem
{
    public Arrow() : base(0.1f, 0.05f) { }
}

class Bow : InventoryItem
{
    public Bow() : base(1f, 4f) { }
}

class Rope : InventoryItem
{
    public Rope() : base(1f, 1.5f) { }
}

class Water : InventoryItem
{
    public Water() : base(2f, 3f) { }
}
class Food : InventoryItem
{
    public Food() : base(1f, 0.5f) { }
}
class Sword : InventoryItem
{
    public Sword() : base(5f, 3f) { }
}
