using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Video_Learning_CSharp
{
    internal class Practice
    {
        static void Main(string[] args)
        { 
            // Одномерные массивы
            {
                // Заполняем массив рандомными числами
                {
            
                    int[] ints = new int[10];
            
                    Random rnd = new Random();
            
            
                    for (int i = 0; i < ints.Length; i++)
                    {
                        ints[i] = rnd.Next(0, 10);
                        Console.Write(ints[i] + " ");
                    }
                    Console.WriteLine();
            
                }
                // Заполняем массив сразу после его объявления нужными значениями
                {
            
                    int[] ints = { 1, 4, 5, short.MaxValue, short.MinValue }; // Массив с неопределенным количеством элементов, которые можно добавлять до бесконечности
                    int[] ints1 = new int[5] { 1, 2, 3, 4, 5 }; // Массив с заданным количеством элементов, максимальное количество которых не должно превышаться 
            
                    for (int i = 0; i < ints.Length; i++)
                    {
                        Console.Write(ints[i] + " ");
                    }
                    Console.WriteLine();
            
                }
                // Находим максимальное число массива
                {
                    int maxValue = int.MinValue;
                    int[] ints = new int[5] { 12, -2, 34, 4, 15 }; // Массив с заданным количеством элементов, максимальное количество которых не должно превышаться 
            
                    for (int i = 0; i < ints.Length; i++)
                    {
                        if (maxValue < ints[i])
                        {
                            maxValue = ints[i];
                        }
                    }
                    Console.WriteLine(maxValue);
                }
            
            
            }
        }
    }
}
