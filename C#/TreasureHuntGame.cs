using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class ProjectFindAllTreasures
{
    static void Main(string[] args)
    {
        int userX = 1, userY = 1; // координаты игрока в массиве (карте)
        int foundTreasures = 0; // счетчик сколько найдено сокровищ на данный момент
        int requiredTreasures = 5; // число необходимых нацденных сокровищ

        bool isPlaying = true;
        bool foundWayOut = false;


        char[,] map =
        {
            { '-', '-', '-', '-', '-','-', '-', '-', '-', '-','-', '-', '-', '-', '-','-', '-', '-', '-', }, // Это наш двумерный массив - карта - 
            { '=', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ',' ',' ',' ',' ',' ','|',' ',' ',' ','|'},          // мы по ней управляем персонажем и ищем сокровища
            { '|', ' ', '|', ' ', '-', '-', '-', '-', '-',' ','-','-','-',' ','|',' ','|',' ','|'},
            { '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|',' ','|','~','|',' ','|',' ','|',' ','|'},
            { '|', ' ', '-', '-', '-', '-', '-', ' ', '|',' ','|',' ','|','~','|',' ','|',' ','|'},
            { '|', ' ', ' ', ' ', '|', '~', '|', ' ', '|',' ','|',' ','-','-','-',' ','|',' ','|'},
            { '|', ' ', '|', ' ', '|', ' ', ' ', ' ', '|',' ','|',' ',' ',' ',' ',' ','|',' ','|'},
            { '|', ' ', '|', ' ', '-', '-', '-', ' ', '|',' ','-','-','-','-','-',' ','|',' ','|'},
            { '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|',' ',' ',' ',' ',' ','|',' ','|',' ','|'},
            { '|', ' ', '|', '-', '-', '-', '-', '-', '-','-','-',' ','|',' ','|',' ','|',' ','|'},
            { '|', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ',' ','|',' ','|',' ','|',' ','|',' ','|'},
            { '|', ' ', '|', ' ', '-', '-', '-', '-', '-',' ','|','~','|',' ','|',' ','|',' ','|'},
            { '|', ' ', ' ', ' ', '|', ' ', '~', ' ', '|',' ','-','-','-',' ','|',' ','|',' ','|'},
            { '|', ' ', '|', ' ', '|', ' ', ' ', ' ', ' ',' ',' ',' ',' ',' ',' ',' ','|',' ','#'},
            { '-', '-', '-', '-', '-','-', '-', '-', '-', '-','-', '-', '-', '-', '-','-', '-', '-', '-', }

        };


        Console.CursorVisible = false; // отключаем вечно мигающий курсор

        while (isPlaying)
        {
            Console.SetCursorPosition(25, 5); // устанавливаем позицию для визуального размещения заданий
            Console.Write("Tasks: ");
            Console.SetCursorPosition(25, 7);
            Console.Write($"Find all the treasures: {foundTreasures} / {requiredTreasures}"); // счетчик выполнения задания по нахождению сокровищ
            Console.SetCursorPosition(25, 8);
            Console.Write($"Find the way out: {Convert.ToInt32(foundWayOut)} / 1"); //  счетчик выполнения задания по нахождению выхода


            Console.SetCursorPosition(0, 0); // устанавливаем позицию размещения карты
            for (int i = 0; i < map.GetLength(0); i++) // отображаем карту методом перебора и вывода всех элементов двумерного массива
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }

            Console.SetCursorPosition(userY, userX); // устанавливаем позицию для размещения игрока
            Console.Write('*'); // размещаем игрока на стартовой позиции
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(); // считываем нажатия с клавиатуры

            switch (consoleKeyInfo.Key) // сравниваем нажатую клавишу с управлением в игре
            {
                case ConsoleKey.W:
                    if (map[userX - 1, userY] != '|' && map[userX - 1, userY] != '-')
                    {
                        userX--;
                    }
                    break;
                case ConsoleKey.S:
                    if (map[userX + 1, userY] != '|' && map[userX + 1, userY] != '-')
                    {
                        userX++;
                    }
                    break;
                case ConsoleKey.A:
                    if (map[userX, userY - 1] != '|' && map[userX, userY - 1] != '-' && map[userX, userY - 1] != '=')
                    {
                        userY--;
                    }
                    break;
                case ConsoleKey.D:
                    if (map[userX, userY + 1] != '|' && map[userX, userY + 1] != '-')
                    {
                        userY++;
                    }
                    break;
            }

            if (map[userX, userY] == '~') // каждый ход (итерацию) проверяем не стоит ли игрок на клетке с сокровищем
            {
                map[userX, userY] = 'o'; // если стоит, то символ сокровища меняем на "о"
                foundTreasures++; // если стоит, то прибавляем к счетчику сокровищ 1
            }
            if (map[userX, userY] == '#' && foundTreasures == requiredTreasures) // каждый ход (итерацию) проверяем не стоит ли игрок на клетке с выходом, и не хватает ли
                                                                                 // игроку сокровищ для прохождения
            {
                foundWayOut = true; // если стоит, и хватает, то обозначаем, что игрок нашел выход
            }
            if (foundWayOut && foundTreasures == requiredTreasures) // если игрок собрал все сокровища и нашел выход,
                                                                    // то завершаем цикл (игру)
            {
                isPlaying = false;
            }

            Console.Clear(); // обновляем консоль каждый ход (итерацию) чтобы отображать изменения
                             // изменения будут происходить в любом случае, пока цикл запущен, однако мы не увидим этих изменений без обновления консоли
        }
        Console.WriteLine("You won!"); // Выигрыш!

    }
}
