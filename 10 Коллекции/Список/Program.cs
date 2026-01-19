using System.Collections.Generic;
namespace Список
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            using System.Collections.Generic;
            List<string> strings = new List<string>();
            List<string> strings = new List<string>() { "Элемент 1", "Элемент 2" };
            List<string> strings = ["Элемент 1", "Элемент 2"];

            strings.Add("Элемент 3");
            strings.Insert(0, "Элемент 0"); // вставляет значение "Элемент 0" по индексу 0

            List<int> numbers1 = new List<int>() { 1, 2, 3 };
            List<int> numbers2 = new List<int>() { 4, 5, 6 };
            numbers1.AddRange(numbers2); // 1 2 3 4 5 6
            numbers1.InsertRange(2, numbers2); // 1, 2, 4, 5, 6, 3
            
            Console.WriteLine(strings.Count);

            for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine(strings[i]);
            }

            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine(string.Join('+', numbers)); // 1+2+3

            int index = strings.IndexOf("Элемент 3");
            int index = strings.LastIndexOf("Элемент 3");
            List<int> newList = number.GetRange(2, 3);
            bool isContains = strings.Contains("Элемент 3");
            strings.Remove("Элемент 2");
            strings.RemoveAt(1); // удаляет элемент под индексом 1

            int index = strings.IndexOf("Элемент 2"); // найти индекс элемента, который равен "Элемент 2"
            if (index >= 0) // если такой индекс есть
            {
                strings.RemoveAt(index); // удалить элемент по индексу
            }

            strings.Clear();

            strings.Sort();

            numbers.Sort(); // 2 3 4
            numbers.Reverse(); // 4 3 2

             */

            List<List<int>> numberLists = new List<List<int>>();

            numberLists.Add(new List<int> { 1, 2, 3 }); // Добавляем первый список: {1, 2, 3}
            numberLists.Add(new List<int> { 4, 5, 6 }); // Добавляем второй список: {4, 5, 6}
            numberLists.Add(new List<int> { 7, 8, 9 }); // Добавляем второй список: {7, 8, 9}

            foreach (var list in numberLists)
            {
                Console.WriteLine(string.Join(" ", list));
            }

        }
    }
}
