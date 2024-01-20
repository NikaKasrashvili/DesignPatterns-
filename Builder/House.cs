namespace Builder;


/// <summary>
/// Final product, that we want to build.
/// </summary>
internal class House
{
    private List<object> _parts = new List<object>();

    /// <summary>
    /// Add parts for the product (House).
    /// </summary>
    /// <param name="part"></param>
    public void Add(string part)
    {
        _parts.Add(part);
    }

    // after saving parts into _parts list, iterate through them and
    // add those parts into "str" variable.
    public string ListParts()
    {
        string str = string.Empty;

        for (int i = 0; i < _parts.Count; i++)
        {
            str += _parts[i] + ", ";
        }

        //remove last comma
        str = str.Remove(str.Length - 2); 

        return "House parts: " + str + "\n";
    }
}
