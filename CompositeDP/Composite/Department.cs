using CompositeDP.Component;

namespace CompositeDP.Composite;

/// <summary>
/// <strong>Composite class</strong> representing a department, 
/// which can contain both individual employees and other departments.
/// </summary>
internal class Department : IEmployee
{
    private readonly string? _name;

    private List<IEmployee> _employees = new List<IEmployee>();

    public Department(string name)
    {
        _name = name;
    }

    /// <summary>
    /// Method to add an employee (either an individual employee or another department) 
    /// to this department
    /// </summary>
    /// <param name="employee"></param>
    public void AddEmployee(IEmployee employee)
    {
        _employees.Add(employee);
    }

    // Implementation of DisplayDetails method for departments
    public void DisplayDetails()
    {
        Console.WriteLine($"Department: {_name}");

        foreach (var employee in _employees)
        {
            employee.DisplayDetails(); // Display details of each employee (individual or department) in this department
        }
    }
}
