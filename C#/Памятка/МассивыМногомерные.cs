// Многомерные массивы
{
    int[,] ints = new int[2, 4];

    Random rnd = new Random();
    

    Console.WriteLine("Общее количество элементов в массиве: " + ints.Length); // Выводит общее количество элементов в массиве

    for (int i = 0; i < ints.GetLength(0); i++) // ints.GetLength(0) - 0 - Первое измерение (строки)
    {
        Console.WriteLine();
        for (int j = 0; j < ints.GetLength(1); j++) // ints.GetLength(1) - 1 - Второе измерение (столбцы)
        {
            ints[i,j] = rnd.Next(0);
            Console.Write(ints[i, j] + " ");
        }
    }
    Console.WriteLine("\n");
}
