namespace Builder;

/// <summary>
/// Interface of builder dp, that defines methods
/// for creating the different parts of the Product objects.
/// </summary>
internal interface IHouseBuilder
{
    /// <summary>
    /// Sets the type of House. F.ex."wooden", "victorian", "farmhouse"...
    /// </summary>
    /// <param name="type"></param>
    void SetType(string type);                      //build partA 
    /// <summary>
   /// Defines how many rooms should house have.
   /// </summary>
   /// <param name="rooms"></param>
    void SetRooms(int rooms);                       //build partB 
    /// <summary>
    /// Sets the type of room - "flat", "gable", "mansard"...
    /// </summary>
    /// <param name="roofType"></param>
    void SetRoofType(string roofType);              //build partC 
    /// <summary>
    /// Defines flooring type - "laminate", "plank", "solid hardwood"...
    /// </summary>
    /// <param name="flooringType"></param>
    void SetFlooringType(string flooringType);      //build partD 
    /// <summary>
    /// Defines whether or not house have balcony.
    /// </summary>
    void BuildBalcony ();                           //build partE
}
 