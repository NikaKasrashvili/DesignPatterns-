namespace CompositeDP.Component;

/// <summary>
/// <strong> Component   </strong> interface that defines the common operations for individual employees and departments.
/// </summary>
internal interface IEmployee
{
    /// <summary>
    /// Method declared in <see cref="IEmployee"/> component interface.<br/>
    /// It's common for both simple and complex objects.
    /// </summary>
    void DisplayDetails();
}
