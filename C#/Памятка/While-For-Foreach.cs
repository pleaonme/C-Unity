// Цикл While
{
    int age;

    Console.Write("Please, enter your age here: ");
    age = int.Parse(Console.ReadLine());

    while (age-- > 0)
    {
        Console.WriteLine(age);
    }

}




// Цикл For
{
    // #1
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine(i);
    }

    int attemptsCount = 5;
    string password = "qwerty";
    string userInput;



    while (attemptsCount-- > 0)
    {
        Console.Write("Please enter your password here: ");
        userInput = Console.ReadLine();
        if (userInput == password)
        {
            Console.WriteLine("Right password! Acces is allowed.");
            break;
        }
        else
        {
            Console.WriteLine($"Password is not correct. You have {attemptsCount} attempts left");
        }
    }
    // #2

    float money;
    int percent = 7;
    int term;

    Console.WriteLine("Welcokme to the the Visual National Bank! Interest on deposit is %" + percent);

    Console.Write("Enter count of money for deposit: ");
    money = Convert.ToSingle(Console.ReadLine());
    Console.Write("Enter the term of deposit (in years): ");
    term = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < term; i++)
    {
        money += money / 100 * percent;
        Console.WriteLine($"On {i} years you'll have {money} money.");
        Console.ReadKey();
    }


  
  // Цикл Foreach
  {
      // Foreach используются при переборе элементов массива без указания и обращения индекса каждого элемента
  
      int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
  
      for (int i = 0; i < numbers.Length; i++) // перебираем и выводим наш массив через for, обращаясь к индексу каждого элемента
      {
          Console.Write(numbers[i] + " ");
      }
      Console.WriteLine();
      foreach (int i in numbers) // перебираем и выводим каждый элемент массива, не обращаясь к их индексам
      {
          Console.Write(i + " ");
      }
  
  }
}
