namespace Builder;


/// <summary>
/// Final product, that we want to build.
/// </summary>
internal class House
{
    private List<object> _parts = new List<object>();

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public string ListParts()
    {
        string str = string.Empty;

        for (int i = 0; i < _parts.Count; i++)
        {
            str += _parts[i] + ", ";
        }

        str = str.Remove(str.Length - 2); 

        return "House parts: " + str + "\n";
    }
}
