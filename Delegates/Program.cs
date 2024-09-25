internal class Program
{
    private static void Main(string[] args)
    {
        // instatiate the delegate
        Callback handler = DelegateMethod;

        // call the delegate
        handler("Hello World");
    }

    public delegate void Callback(string message);

    // create method for delegate.
    public static void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }

}