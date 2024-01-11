namespace Singleton;


//
// Summary:
// This Singleton implementation uses
// Techniques such as "double check lock" and the lock statement
// To ensure that the creation of the instance is synchronized across multiple threads.
// It is safe in multithreaded environment and provides lazy initialization for the
// Singleton object.



// By marking the class as sealed, we are preventing other classes from inheriting from it. 
// In the context of a Singleton, inheritance is typically not desired, 
// as it could lead to multiple instances of the class if a derived class attempts to create its own instance.
public sealed class SingletonClass
{
    // Using a private static readonly instance to ensure thread safety.
    private static readonly object _lock = new object();
    private static SingletonClass? _instance;
    public static string? Id { get; private set; }

    #region Constructor

    /// <summary> 
    /// Constructor of Singleton type class must be private 
    /// to prevent instantiation from outside.
    /// </summary>
    private SingletonClass()
    {
        Id = Guid.NewGuid().ToString(); //Only for testing purposes

        // Initialization code, if needed.
    }

    #endregion

    /// <summary>
    /// <para> 
    ///     Public method to get the instance of the class.
    /// </para>
    /// <para>
    ///     To ensure for thread safety, we have to double-check locking for it. <br/>
    ///     If there's no Singleton instance created yet, multiple threads can
    ///     simultaneously try to pass it at the same time.<br/>
    ///     We must ensure, that the first thread will lock and 
    ///     proceed further. 
    /// </para>
    /// </summary>
    public static SingletonClass GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new SingletonClass();
                    Console.WriteLine("Singleton instance has been created");
                }
            }

        }

        return _instance;
    }
}

