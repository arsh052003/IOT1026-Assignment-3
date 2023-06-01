namespace Assignment;

public class Pack
{
    private InventoryItem[] _items; // You can use another data structure here if you prefer.
    // You may need another private member variable if you use an array data structure.
    //initialize the variables to keep track of _maxCount, _maxVolume, _maxWeight, _currentVolume, _currentWeight and _currentCount.
    private int _maxCount;
    private float _maxVolume;
    private float _maxWeight;
    private float _currentWeight = 0;
    private float _currentVolume = 0;
    private float _currentCount = 0;

    //Creating getter to get private variables above
    public int Get_maxCount()
    {
        return _maxCount;
    }
    public float Get_maxVolume()
    {
        return _maxVolume;
    }
    public float Get_maxWeight()
    {
        return _maxWeight;
    }
    public float Get_currentVolume()
    {
        return _currentVolume;
    }
    public float Get_currentWeight()
    {
        return _currentWeight;
    }
    public float Get_currentCount()
    {
        return _currentCount;
    }

    public Pack(int maxCount, float maxVolume, float maxWeight)
    {
        //throwing error if user provides the negative value for  weight, volume and count.
        if (maxVolume <= 0f || maxWeight <= 0f)
        {
            throw new ArgumentOutOfRangeException($"An item can't have {maxVolume} volume or {maxWeight} weight");
        }
        else if (maxCount <= 0)
        {
            throw new ArgumentOutOfRangeException("You must carry something");
        }
        //setting the size of the array base on maxcount
        _items = new InventoryItem[maxCount];
        _maxCount = maxCount;
        _maxVolume = maxVolume;
        _maxWeight = maxWeight;
    }

    //This method is used to adding the items.
    //Method will return if the item is added successfully .
    public bool Add(InventoryItem item)

    {
        //In this if statement we are checking if the adding item go beyond the pack limit.
        //we are using itemVolume + currentVolume is less than pack's Volume.  `
        if (item.GetVolume() + _currentVolume < _maxVolume && item.GetWeight() + _currentWeight < _maxWeight)
        {
            //checking through inventoryitems
            for (int index = 0; index < _maxCount; index++)
            {
                //if the index of array is empty then add the item.
                if (_items[index] == null)
                {
                    //adding the item
                    _items[index] = item;
                    //here we are updating the currentCount of the pack.
                    _currentCount = index + 1;
                    //updating the currentVolume and currentWeight of the pack.
                    _currentVolume = item.GetVolume() + _currentVolume;
                    _currentWeight = item.GetWeight() + _currentWeight;
                    return true;
                }
            }


        }
        //if there is no enough volume and weight in pack.
        //and  if the capacity of pack is full, it will return false.
        Console.WriteLine("pack limit is full");
        return false;


    }

    // Implement this class.
    //This method give information about the items in the pack.
    public override string ToString()
    {
        return $"Pack is currently at {_currentCount}/{_maxCount} items, {_currentWeight}/{_maxWeight} weight, and {_currentVolume}/{_maxVolume} volume.";
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

// Implement these classes - each inherits from InventoryItem.
// 1 line of code each - call base class constructor with appropriate arguments.
public class Arrow : InventoryItem
{
    public Arrow() : base(0.1f, 0.05f) { }
}

public class Bow : InventoryItem
{
    public Bow() : base(1f, 4f) { }
}

public class Rope : InventoryItem
{
    public Rope() : base(1f, 1.5f) { }
}

public class Water : InventoryItem
{
    public Water() : base(2f, 3f) { }
}
public class Food : InventoryItem
{
    public Food() : base(1f, 0.5f) { }
}
public class Sword : InventoryItem
{
    public Sword() : base(5f, 3f) { }
}
