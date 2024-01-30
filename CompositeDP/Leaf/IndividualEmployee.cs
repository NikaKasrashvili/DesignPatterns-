using CompositeDP.Component;

namespace CompositeDP.Leaf;

/// <summary>
///  <strong> Leaf class  </strong> representing an individual employee.
/// </summary>
internal class IndividualEmployee : IEmployee
{
    private readonly string? _name;
    private readonly int _age;
    private readonly string? _position;

    public IndividualEmployee(string name, int age, string position)
    {
        _name = name;
        _age = age;
        _position = position;
    }

    // Implementation of DisplayDetails method for individual employees.
    public void DisplayDetails()
    {
        Console.WriteLine($"Individual Employee: {_name} is {_age} years old and works as a(n) {_position}");
    }
}
