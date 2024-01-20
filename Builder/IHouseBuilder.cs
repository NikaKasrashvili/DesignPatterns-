namespace Builder;

/// <summary>
/// Interface of builder dp, that defines methods
/// for creating the different parts of the Product objects.
/// </summary>
internal interface IHouseBuilder
{
    void SetType(string type);                      //build partA 
    void SetRooms(int rooms);                       //build partB 
    void SetRoofType(string roofType);              //build partC 
    void SetFlooringType(string flooringType);      //build partD 
    void BuildBalcony ();                           //build partE
}
 