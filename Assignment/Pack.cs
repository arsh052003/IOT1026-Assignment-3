namespace Assignment;

public class Pack
{
    private InventoryItem[] _items; // You can use another data structure here if you prefer.
    // You may need another private member variable if you use an array data structure.
    private int _maxCount;
    private float _maxVolume;
    private float _maxWeight;
    private float _currentweight = 0;
    private float _currentVolume = 0;
    private float _currentCount = 0;
    public Pack(int maxCount, float maxVolume, float maxWeight)
    {
        _items = new InventoryItem[maxCount];
        _maxCount = maxCount;
        _maxVolume = maxVolume;
        _maxWeight = maxWeight;
    }

    public bool Add(InventoryItem item)

    {
        if (item.GetVolume() + _currentVolume < _maxVolume && item.GetWeight() + _currentweight < _maxWeight)
        {
            Console.WriteLine("we can add the properties of item in pack ");
            for (int index = 0; index < _maxCount; index++)
            {
                if (_items[index] == null)
                {
                    _items[index] = item;
                    _currentCount = index + 1;
                    _currentVolume = item.GetVolume() + _currentVolume;
                    _currentweight = item.GetWeight() + _currentweight;
                    return true;
                }
            }


        }
        Console.WriteLine("pack limit is full");
        return false;


    }

    // Implement this class
    public override string ToString()
    {
        return $"Pack is currently at {_currentCount}/{_maxCount} items, {_currentweight}/{_maxWeight} weight, and {_currentVolume}/{_maxVolume} volume.";
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
