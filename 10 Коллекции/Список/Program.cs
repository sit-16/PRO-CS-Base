using Microsoft.VisualBasic;
using System.Collections.Generic;
namespace Список
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_base_11_2_1(); //11.2 Задачи базового уровня.Заполни список
            //Task_base_11_2_2(); //11.2 Задачи базового уровня. Вывод чисел
            //Task_base_11_2_3(); //11.2 Задачи базового уровня. Не знаю что выбрать
            //Task_base_11_3_1(); //11.3 Задачи легкого уровня.Запросы лингвистов
            Task_base_11_3_2(); //11.3 Задачи легкого уровня.Книги о Гарри Поттере
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
        
        static void Task_base_11_3_1() //11.3 Задачи легкого уровня.Запросы лингвистов
        {
            string target = "abcdabcaaa";
            char symbol = 'a';
            string result = string.Join(", ", IndexOfAll(target, symbol));
            Console.WriteLine(result);
        }


        static List<int> IndexOfAll(string target, char symbol) //11.3 Задачи легкого уровня.Запросы лингвистов
        {
            List<int> count = new List<int>();
            for (int i = 0; i< target.Length;i++) 
            {
                if (target[i] == symbol)
                {
                    count.Add(i);
                }
            }
            return count;
        }


        static void Task_base_11_2_3() //11.2 Задачи базового уровня. Не знаю что выбрать
        {
            int n = int.TryParse(Console.ReadLine(), out n) ? n : 0; //количество элементов в списке
            List<string> books = new List<string>();
            for (int i = 0; i < n; i++)
            {
                books.Add(Console.ReadLine());
            }
            int bookN = int.TryParse(Console.ReadLine(), out bookN) ? bookN : 0;
            int bookCount = int.TryParse(Console.ReadLine(), out bookCount) ? bookCount : 0;
            int bookLast = bookN + bookCount ;
            if (bookLast <= books.Count)
                Console.WriteLine(string.Join("\n", books[bookN..bookLast]));
            else
                Console.WriteLine("Неверный ввод");
        }

        
        static void Task_base_11_3_2() //11.3 Задачи легкого уровня.Книги о Гарри Поттере
        {
            int n = int.TryParse(Console.ReadLine(), out n) ? n : 0; //количество книг на полке
            List<string> books = new List<string>();
            for (int i = 0; i < n; i++)
            {
                books.Add(Console.ReadLine());
            }
            string new_book_name = Console.ReadLine();
            int new_book_pos = Convert.ToInt32(Console.ReadLine()) - 1;
            string gived_book_name = Console.ReadLine();
            string desired_book_name = Console.ReadLine();
            books.Insert(new_book_pos, new_book_name);
            books.Remove(gived_book_name);
            int desired_book_pos = books.IndexOf(desired_book_name)+1;
            Console.WriteLine(desired_book_pos);
        }
    }
}   

