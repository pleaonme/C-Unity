using System;

internal class ProjectLibrary
{
    // Global
    public static bool isWorking = true;
    public static string userComandAnswer;
    public static string[,] strings = new string[3, 5]
    {
        { "Назад в будущее", "Три поросенка", "Молчание ягнят", "Ловец снов" , "Остров проклятых"},
        { "Ходячие мертвецы", "Бойтесь мертвецов", "Изгоняющий дьявола", "Ведьма из Блэр" , "Окулус"},
        { "Ведьмак", "Пятнадцатилетний капитан", "Алиса в стране чудес", "Зазеркалье" , "Гарри Поттер"}
    };
    // 1st method's
    public static string choosenBook;
    // 2nd method;s
    public static string userTakeBookAnswer;
    public static string findedBook = "";
    // 3rd method's
    public static string[] takenBooks = { };
    // Program
    public static void Main(string[] args)
    {

        Console.WriteLine("Общее количество элементов в массиве: " + strings.Length); // Выводит общее количество элементов в массиве

        while (isWorking)
        {

            Console.WriteLine("Welcome to the our new Library!");
            Console.WriteLine("What do you want to read today?\n\n");

            Console.WriteLine("1 - find the book from shelf\n2 - find the book with name\n3 - show taken books\n4 - leave the library\n");
            Console.Write("Text your comand here: ");

            userComandAnswer = Console.ReadLine();

            switch (userComandAnswer)
            {
                case "1":
                    FindTheBookFromShelf();
                    Console.WriteLine("\n\nGreat choice! Now you can read " + choosenBook + " book with pleasure!");
                    break;
                case "2":
                    FindTheBookWithName();
                    break;
                case "3":
                    ShowTakenBooks();
                    break;
                case "4":
                    isWorking = false;
                    break;
                default:
                    Console.WriteLine("Unknown comand. Please, read the notation.");
                    break;
            }

            Console.WriteLine("\n");
            Console.Write("\n\n\n\nWrite something to continue... ");
            Console.ReadLine();
            Console.Clear();

        }

    }

    public static string FindTheBookFromShelf()
    {
        int choosenShelf;
        int bookNumber = 0;

        Console.Write("From which shelf do you want to take the book? (1-3): ");
        choosenShelf = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nOk! There's {strings.GetLength(1)} books on the {choosenShelf} shelf.");
        Console.Write("\nThere is: ");
        for (int i = 0; i < strings.GetLength(1); i++)
        {
            bookNumber++;
            Console.Write(bookNumber + " - " + strings[choosenShelf - 1, i] + " ");
        }
        Console.WriteLine("\n\n");
        Console.Write("Whick book do you want to read? Text the number here: ");
        choosenBook = Console.ReadLine();
        choosenBook = strings[choosenShelf - 1, int.Parse(choosenBook) - 1];
        Console.WriteLine($"\nYou've choosed {choosenBook}!");

        takenBooks = choosenBook.Split(',');

        return choosenBook;
    }
    public static void FindTheBookWithName()
    {
        string userInput;

        bool bookDoesntExists = true;

        Console.Write("Write the name of the book: ");
        userInput = Console.ReadLine();
        for (int i = 0; i < strings.GetLength(0); i++)
        {
            for (int j = 0; j < strings.GetLength(1); j++)
            {
                if (userInput.ToLower() == strings[i, j].ToLower())
                {
                    Console.WriteLine($"The book {strings[i, j]} is on the {i + 1} shelf by number {j + 1}.");
                    findedBook = strings[i, j];
                    bookDoesntExists = false;
                }
            }

        }

        if (bookDoesntExists)
        {
            Console.WriteLine("We can't find that book. Please, try again.");
        }
        else
        {
            Console.Write("Since you asked about this book - Do you want to take and read it? Y / N: ");
            userTakeBookAnswer = Console.ReadLine();
            if (userTakeBookAnswer == "Y")
            {
                choosenBook = findedBook;
                Console.WriteLine($"You've choosed {findedBook}!");
                takenBooks = choosenBook.Split(',');
            }
        }
    }
    public static void ShowTakenBooks()
    {
        Console.WriteLine("There is your taken from library books: ");
        for (int i = 0; i < takenBooks.Length; i++)
        {
            Console.Write(takenBooks[i] + " ");
        }
    }
}
