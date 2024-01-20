namespace Builder;

/// <summary>
/// Director class, executing the building steps.
/// </summary>
internal class HouseDirector
{
    private IHouseBuilder _houseBuilder;

    public IHouseBuilder HouseBuilder
    {
        set { _houseBuilder = value; }
    }

    // construct several product variations. 
    public void BuildModernHouse()
    {
        _houseBuilder.SetType("Modern");
        _houseBuilder.SetFlooringType("wooden");
        _houseBuilder.SetRoofType("flat");
        _houseBuilder.SetRooms(4);
    }

    public void BuildBalconyHouse()
    {
        _houseBuilder.BuildBalcony();
        _houseBuilder.SetType("Modern");
        _houseBuilder.SetRooms(4);
    }

}
