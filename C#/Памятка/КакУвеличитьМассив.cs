// Ссылочные типы
{
    // Как увеличить массив?
    {
        int[] bag = new int[2];
        int[] tempBag = new int [bag.Length + 1];

        bag [0] = 10;
        bag [bag.Length-1] = 20;

        for (int i = 0; i < bag.Length; i++)
        {
            tempBag [i] = bag [i];
            Console.WriteLine(tempBag[i]);
        }

        Console.WriteLine();

        bag = tempBag;

        for (int i = 0; i < bag.Length; i++)
        {
            Console.WriteLine(bag[i] + "Cycle 2");
        }
        Console.WriteLine();

    }
    // Гаражи
    {
        int[] petrovich = new int[3]; // создаем новый массив 'petrovich' размером 3 элемента
        int[] ivanovich = new int[5]; // создаем новый массив 'ivanovich' размером 5 элементов

        int[] sidorovich;

        petrovich = ivanovich; // перезаписываем массив 'petrovich' параметрами 'ivanovich'
                               // в массиве 'petrovich' становится так же 5 элементов
                               // оба массива теперь ссылаются на одну и ту же область памяти

        petrovich[0] = 5; // в 1 элемент массива 'petrovich' записываем значение 5 
        petrovich[1] = 2;
        //Меняем значение в области памяти на которую ссылаются оба массива
        // теперь в массиве 'ivanovich' так же хранится 1 элемент со значением 5

        // При перезаписывании массива 'petrovich' и приравнивании его к массиву 'ivanovich',
        // прежняя область памяти массива 'petrovich' удаляется и остается только область памяти массива 'ivanovich', к которой ссылаются оба массива

        sidorovich = petrovich;

        sidorovich[2] = 8;
        sidorovich[0] = 4;

        Console.WriteLine(ivanovich[0]);
        Console.WriteLine(ivanovich[1]);
        Console.WriteLine(ivanovich[2]);

        petrovich = new int[10]; // заново обьявляем массив 'petrovich' с пустыми значениями элементов и отдельной областью памяти

        // Если ни один из ранее ссылающихся массивов более не ссылается на эту область памяти, то эта область памяти удаляется
    }
}
