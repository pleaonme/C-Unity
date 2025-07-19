using System;

class Program
{
    private delegate void PrintMessageDelegate(string str); // Define a delegate type which takes an int parameter

    private delegate void TestDelegate();


    static void Main(string[] args)
    {
        PrintMessageDelegate printMessage = PrintMessage; // Create an instance of the delegate
        printMessage("Hello, World!");



        Action<string> action = PrintMessage; // Action is a built-in delegate with params

        Func<string, int> addNumbers = int.Parse; // Func is a built-in delegate that takes params (string) and returns a value (int)



        Func<int, bool> myAction = (int x) => // Lambda expression - it basically represents a method without defining it explicitly
        {
            return x > 0;
        };



        TestDelegate testDelegate;

        testDelegate = Function1;
        testDelegate += Function2; // Both methods will be called

    }
    
    private static void PrintMessage(string message)
    {
        Console.WriteLine($"Message: {message}");
    }

    private static void Function1()
    {
        Console.WriteLine("Function 1 called");
    }

    private static void Function2()
    {
        Console.WriteLine("Function 2 called");
    }

}
