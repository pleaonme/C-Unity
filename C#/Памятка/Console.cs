// Работа с консолью
        {
            Console.SetCursorPosition(2, 3); // задаем позицию курсору (впоследствии сбросится из-за функции Console.Clear();
            Console.ForegroundColor = ConsoleColor.White; // меняем цвет текста в консоли
            Console.BackgroundColor = ConsoleColor.DarkRed; // меняем цвета фона текста в консоли
            Console.Clear(); // очищаем консоль
            Console.WindowHeight = 50; // меняем высоту окна консоли 
            Console.WindowWidth = 50; // меняем ширину консоли
            Console.WriteLine("Hey! How are you doing today?\nHello! I'm good, and you?"); // \n делает перенос строки на следующую

            string message = "jastin timberlake";
            Console.WriteLine(message.ToLower()); // приводим наше сообщение к нижнему регистру
            Console.WriteLine(message.ToUpper()); // приводим наше сообщение к верхнему регистру


            Console.ReadKey();
            Console.Clear();
        }
        

        // Активация языковых стандартов Кириллицы в консоли (если не работает само)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
