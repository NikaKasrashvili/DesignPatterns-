namespace Builder.ConcreteBuilders;

/// <summary>
/// Concrete builder class, that follows builder interface.
/// </summary>
internal class HouseBuilder : IHouseBuilder
{
    // create an instrance oh House class
    private House _house = new House();

    #region constructor
    public HouseBuilder()
    {
        Reset();
    }
    public void Reset()
    {
        _house = new House();
    }
    #endregion

    #region implemented Methods

    public void BuildBalcony()
    {
        _house.Add("Balcony");
    }

    public void SetFlooringType(string flooringType)
    {
        _house.Add($"floor: {flooringType}");
    }

    public void SetRoofType(string roofType)
    {
        _house.Add($"roof: {roofType}");
    }

    public void SetRooms(int rooms)
    {
        _house.Add($"rooms: {rooms}");
    }

    public void SetType(string type)
    {
        _house.Add($"type: {type}");
    }
    #endregion

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
