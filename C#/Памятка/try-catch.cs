// Try-catch allows us to test risky code on errors, and if there is some, we call catch code block

try
{
    int result = 10 / divisor; // divisor might be 0
}
catch (DivideByZeroException e) // DivideByZeroException - Built-in Exception type
{
    Console.WriteLine("Cannot divide by zero!");
}

// We can use multiple catches for different exceptions

catch (Exception ex) // EXception - Default Exception type
{
    Console.WriteLine($"General failure: {ex.Message}");
}
finally { // Runs no matter what
  Console.WriteLine("Exception check succeed!");
}
