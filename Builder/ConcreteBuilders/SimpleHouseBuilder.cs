namespace Builder.ConcreteBuilders;

/// <summary>
/// Concrete builder class, that follows builder interface.
/// </summary>
internal class SimpleHouseBuilder : IHouseBuilder
{
    private House _house = new House();

    #region constructor
    public SimpleHouseBuilder()
    {
        Reset();
    }
    public void Reset()
    {
        _house = new House();
    }
    #endregion

    public void BuildBalcony()
    {
        _house.Add("Balcony has been added");
    }

    public void SetFlooringType(string flooringType)
    {
        _house.Add(flooringType);
    }

    public void SetRoofType(string roofType)
    {
        _house.Add(roofType);
    }

    public void SetRooms(int rooms)
    {
        _house.Add(rooms.ToString());
    }

    public void SetType(string type)
    {
        _house.Add(type);
    }

    /// <summary>
    /// method for retrieving made product.
    /// </summary>
    /// <returns>created object(product) of <see cref="House"/> class</returns>
    public House BuildHouse()
    {
        House result = _house;
        Reset();
        return result;
    }
}
