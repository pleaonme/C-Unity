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

        shopItems.Add("Melon", 4); // Add a new item to the end of the Dictionary
                                   // .Remove deletes the item as well as in the List

        shopItems["Orange"] = 3; // Reassign the value by using the key

        foreach (var item in shopItems)
        {
            Console.WriteLine($"Item: {item.Key}, Value: {item.Value}"); // Print every item in Dictionary
        }


        if(shopItems.ContainsKey("Banana") {
            Console.WriteLine("Banana is available in the shop."); // If contains "Banana" key
        } else {
            Console.WriteLine("Banana is not available in the shop.");
        }

        if(shopItems.TryGetValue("Apple", out int appleValue){
            Console.WriteLine($"Apple is available with a value of {appleValue}."); // If contains "Apple" + receive output value
        } else {
            Console.WriteLine("Apple is not available in the shop.");
        }

    }
}
