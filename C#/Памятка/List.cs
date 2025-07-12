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
