namespace Prototype;

//step N1: Define the Prototype Interface


/// <summary>
/// Interface that declares a method for cloning objects.
/// </summary>
internal interface ICloneableMachine
{
    /// <summary>
    /// Interface method for cloning objects. Will be implemented into concrete prototype classes
    /// </summary>
    /// <returns><see cref="ICloneableMachine"/> copied object. </returns>
    ICloneableMachine Clone();
    void StartEngine();
}
