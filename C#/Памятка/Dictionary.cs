using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> shopItems = new Dictionary<string, int>
        {
            { "Apple", 3 },
            { "Banana", 2 },
            { "Orange", 5 }
        };

        foreach (var item in shopItems)
        {
            Console.WriteLine($"Item: {item.Key}");
        }

    }
}
