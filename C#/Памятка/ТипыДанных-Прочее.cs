using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Prompt
{
    static void Main(string[] args)
    {
        // Основные типы данных int | float | char | string | bool
        // Целочисленные типы
        {
            /* Приставка перед основными названиями типов переменных: s - signed (sbyte)
             *                                                        u - unsigned (ushort) */

            byte b; // Значение от 0 до 255
            sbyte sb; // Значение от -128 до 127
            short s; // Значение от -32768 до 32767
            ushort us; // Значение от 0 до 65535
            int i; // Значение от -2 147 483 648 до 2 147 483 647
            uint ui; // Значение от 0 до 4 294 672 295
            long l = long.MaxValue; // Значение макс. отображается при наведении курсором на "MaxValue"
            ulong ul = ulong.MinValue; // Значение мин. отображается при наведении курсором на "MinValue"

        }
        // Числа с плавающей точкой
        {
            float f = 3.6f; // Точность значения до 7 знаков после запятой
            double d = 3.6; // Точность значения до 15 знаков после запятой
        }
        // Текстовые типы
        {
            char c = 'a'; // Текстовое значение содержащее один символ
            string str = "string"; // Текстовое значение содержащее набор символов
        }
        // Логический тип
        {
            bool b = true; // Либо True, либо False
        }
        // Инкремент и декремент - постфикс и префикс
        {
            int i = 0;
            i++; // инкремент - постфикс
            ++i; // инкремент - префикс
            i--; // декремент - постфикс
            --i; // декремент - префикс

            // постфикс - переменная сначала возвращается, а затем ее значение изменяется на 1
            // префикс - сначала изменяется значение переменной, а затем переменная возвращается
        }
        // Логические операторы
        {
            // && - и (and) - Если все условия действительны
            // || - или (or) - Если как минимум одно условие действительно
            // != - не равно
        }
        // Генератор чисел Random
        {
            Random rand = new Random();
            int v = rand.Next(0, 10); // Подбираем рандомное число в промежутке от 0 до 10 и записываем в переменную v
                                      // 0 - включительно, 10 - не включительно
        }
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
        // Одномерные массивы
        {
            int[] ints = new int[10]; /* int[] - обозначение одномерного массива
                                       * ints - название массива
                                       * int[10] - количество элементов в массиве */
            int[] ints1 = { 2, 4, 5 }; // Массив с неопределенным количеством элементов, которые можно добавлять до бесконечности
            int[] ints2 = new int[5] { 1, 2, 3, 4, 5 }; // Массив с заданным количеством элементов, максимальное количество которых не должно превышаться 

            Console.WriteLine(System.Array.IndexOf(ints1, 2)); // Выводит индекс элемента 2 в массиве ints1


        }
        // Многомерные массивы
        {
            int[,] ints = new int[3, 5]; /* int[,] - обозначение многомерного массива
                                          * ints - название массива
                                          * int[3, 5] - 3 - в представлении многомерного массива как таблицы это "строка"
                                          *             5 - в представлении многомерного массива как таблицы это "столбец" */

            int[,] ints1 =
            {
                { 2, 3, 4},
                { 7, 1, 5 }
            };

            int[,] ints2 = new int[2, 4]
            {
                {2 , 3, 4, 5},
                { 9, 12, 13, 40 }
            };

        }

        // List
        { 
            List<int> exampleList = new List<int>(); // Инициализация списка с неопредленным количеством элементов с типом int

            exampleList.Add(13); // Добавляем нвоый элемент в список
            exampleList.Add(125);
            exampleList.Add(25);
            
            exampleList.Remove(13); // Удаляем элемент из списка по его значению
            exampleList.RemoveAt(0); // Удаляем элемент из списка по его индексу
            
            exampleList.Insert(1, 13); // Вставить элемент 13 на индекс 1
            
            Console.WriteLine(exampleList.Count); // Count = Length, Выводит количество элементов списка
            
            Console.WriteLine(exampleList.Contains(13)); // Проверка на наличие элемента 13. Выводит True/False
            Console.WriteLine(exampleList.IndexOf(13)); // Выводит индекс элемента 13. Если не находит его, выводит -1
            
            Console.WriteLine(exampleList[0]); // Выводит первый элемент списка
            Console.WriteLine(exampleList[^1]); // Выводит последний элемент списка
        }



        // Активация языковых стандартов Кириллицы в консоли (если не работает само)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
        }
        // Горячие клавиши
        {
            // Ctrl + F5 = Запуск программы
            // Ctrl + Alt = Выбрать множество обьектов
            // Ctrl + K + D = Выровнять все отступы в коде
            // Ctrl + K + C = Закомментировать строку
            // Ctrl + K + U = Раскомментировать строку
            // Ctrl + S = Сохранить файл с кодом
            // Alt + UpArrow / Alt + DownArrow = Перенос строки на позиция выше/ниже
            // Ctrl + UpArrow / Ctrl + DownArrow =  Пролистывание страницы
        }
    }
}
