using Microsoft.VisualBasic;
using System.Collections.Generic;
namespace Список
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_base_11_2_1(); //11.2 Задачи базового уровня.Заполни список
            Task_base_11_2_2(); //11.2 Задачи базового уровня. Вывод чисел
        }


        static void Task_base_11_2_1() //11.2 Задачи базового уровня.Заполни список
        {
            int n = int.TryParse(Console.ReadLine(), out n) ? n : 0; //количество элементов в списке
            List<string> strings = new List<string>();
            for (int i = 0; i < n; i++)
            {
                strings.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", strings));
        }

        static void Task_base_11_2_2() //11.2 Задачи базового уровня. Вывод чисел
        {
            List<int> nums = new List<int>();
            int n = int.TryParse(Console.ReadLine(), out n) ? n : 0; //количество элементов в списке
            for (int i = 0; i < n; i++) // Вносим исходные данные
            {
                nums.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for (int i = 0; i < nums.Count; i++) // Удаляем исключаемые
            {
                if (nums[i] == 4 || nums[i] == 7)
                {
                    nums.RemoveAt(i);
                    i--;
                }
            }

            nums.Sort(); // сортируем по возрастанию
            foreach (int i in nums)
            { 
                Console.WriteLine(i);
            }

            nums.Reverse(); // сортируем по убыванию
            foreach (int i in nums)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
