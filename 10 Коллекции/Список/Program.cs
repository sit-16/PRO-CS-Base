using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Список
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1; i++)
            {
                //Task_base_11_2_1(); //11.2 Задачи базового уровня.Заполни список
                //Task_base_11_2_2(); //11.2 Задачи базового уровня. Вывод чисел
                //Task_base_11_2_3(); //11.2 Задачи базового уровня. Не знаю что выбрать
                //Task_base_11_3_1(); //11.3 Задачи легкого уровня.Запросы лингвистов
                //Task_base_11_3_2(); //11.3 Задачи легкого уровня.Книги о Гарри Поттере
                //Task_base_11_3_3(); //11.3 Задачи легкого уровня.Список курсов
                //Task_base_11_3_4(); //11.3 Задачи легкого уровня.Парад и режисёр
                //Task_base_11_3_5(); //11.3 Задачи легкого уровня.Кредитный скоринг
                //Task_base_11_3_6(); //11.3 Задачи легкого уровня.Криптография
                //Task_base_11_3_7(); //11.3 Задачи легкого уровня.Чашки
                //Task_base_11_3_8(); //11.3 Задачи легкого уровня.Плохая машинистка
                //Task_base_11_4_1(); //11.4 Задачи среднего уровня. К доске
                //Task_base_11_4_2(); //11.4 Задачи среднего уровня. Merge lists 1
                //Task_base_11_4_3(); //11.4 Задачи среднего уровня. Merge lists 2
                //Task_base_11_4_4(); //11.4 Задачи среднего уровня. Хотим "посидеть"
                //Task_base_11_4_5(); //11.4 Задачи среднего уровня. Задача Иосифа Флавия
                //Task_base_11_5_1(); //11.5 Задачи повышенного уровня. Разбиение на чанки
                //Task_base_11_5_2(); //11.5 Задачи повышенного уровня. Подсписки списка
                //Task_base_12_2_1(); //12.2 Задачи базового уровня. Строка
                //Task_base_12_2_2(); //12.2 Задачи базового уровня. Выбор растений
                //Task_base_12_2_3(); //12.2 Задачи базового уровня. Нахождение элемента
                //Task_base_12_2_4(); //12.3 Задачи легкого уровня. Разворот массива
                //Task_base_12_2_5(); //12.3 Задачи легкого уровня. Список покупок
                //Task_base_12_4_1(); //12.4 Задачи среднего уровня. Опечатки при вводе
                //Task_base_12_4_2(); //12.4 Задачи среднего уровня. Правильная скобочная последовательность
                //Task_base_12_4_3(); //12.4 Задачи среднего уровня. Юный помощник
                //Task_base_12_4_3_right(); //12.4 Задачи среднего уровня. Юный помощник
                //Task_base_12_4_4(); //12.4 Задачи среднего уровня. Правильная скобочная последовательность-2
                //Task_base_12_4_4_right(); //12.4 Задачи среднего уровня. Правильная скобочная последовательность-2
                //Task_base_13_2_4(); //13.2 Задачи базового уровня. Заполни очередь
                //Task_base_13_2_5(); //13.2 Задачи базового уровня. Эстафета
                //Task_base_13_2_6(); //13.2 Задачи базового уровня. STOP
                //Task_base_13_2_7(); //13.2 Задачи базового уровня. Чет нечет
                //Task_base_13_3_1(); //13.3 Задачи легкого уровня. Игра в пьяницу
                //Task_base_13_3_2(); //13.3 Задачи легкого уровня. Очередь в поликлинике
                //Task_base_13_4_1(); //13.4 Задачи среднего уровня. Коммутатор
                //Task_base_13_4_2(); //13.4 Задачи среднего уровня. Мальчики и девочки
                //Task_base_14_2_7(); //14.2 Задачи базового уровня. Элементы
                //Task_base_14_2_8(); //14.2 Задачи базового уровня. Совпадение
                //Task_base_14_2_9(); //14.2 Задачи базового уровня. Уникальный
                //Task_base_14_3_1(); //14.3 Задачи легкого уровня. Список курсов 2                
                //Task_base_14_3_2(); //14.3 Задачи легкого уровня. Тимур и Артур
                //Task_base_14_3_3(); //14.3 Задачи легкого уровня. Однофамильцы
                //Task_base_14_4_1(); //14.4 Задачи среднего уровня. Ученики онлайн-школы
                //Task_base_14_4_2(); //14.4 Задачи среднего уровня. Тетради учеников
                //Task_base_15_2_5(); //15.2 Задачи базового уровня. Пары
                //Task_base_15_2_6(); //15.2 Задачи базового уровня. Вывод значения
                //Task_base_15_2_7(); //15.2 Задачи базового уровня. Продукты 
                //Task_base_15_2_8(); //15.2 Задачи базового уровня. Объединение словарей
                //Task_base_15_2_9(); //15.2 Задачи базового уровня. Jingle Bells
                //Task_base_15_2_10(); //15.2 Задачи базового уровня. ВЕРХНИЙ РЕГИСТР
                //Task_base_15_3_1(); //15.2 Задачи базового уровня. Словарь синонимов
                //Task_base_15_3_2(); //15.2 Задачи базового уровня. Страны и города
                //Task_base_15_3_3(); //15.2 Задачи базового уровня. Исправление дубликатов
                //Task_base_15_3_4(); //15.2 Задачи базового уровня. Хотим "посидеть" 2
                //Task_base_15_3_5(); //15.2 Задачи базового уровня. Мотивация
                //Task_base_15_3_6(); //15.2 Задачи базового уровня. Анаграммы 1
                Task_base_15_3_7(); //15.2 Задачи базового уровня. Первичная обработка текстов LLM
            }
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
            for (int i = 0; i < target.Length; i++)
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
            int bookLast = bookN + bookCount;
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
            int desired_book_pos = books.IndexOf(desired_book_name) + 1;
            Console.WriteLine(desired_book_pos);
        }

        static void Task_base_11_3_3() //11.3 Задачи легкого уровня.Список курсов
        {
            int n = int.TryParse(Console.ReadLine(), out n) ? n : 0; //количество элементов в списке
            List<string> cource = new List<string>();
            for (int i = 0; i < n; i++)
            {
                cource.Add(Console.ReadLine());
            }
            n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
            for (int i = 0; i < n; i++)
            {
                cource.Remove(Console.ReadLine());
            }
            if (cource.Count == 0)
                Console.WriteLine("Начните новый курс Иосифа Дзеранова! И станьте еще на шаг ближе к профессии разработчик!");
            else
                foreach (string s in cource)
                {
                    Console.WriteLine(s);
                }
        }

        static void Task_base_11_3_4() //11.3 Задачи легкого уровня.Парад и режисёр
        {
            int num = 6;
            List<int> divisors = GetDivisors(num);
            Console.Write(string.Join(", ", divisors));
        }

        static List<int> GetDivisors(int n)
        {
            List<int> d = new List<int>();
            for (int i = 1; i <= n; i++)
                if (n % i == 0) d.Add(i);
            return d;
        }

        static void Task_base_11_3_5() //11.3 Задачи легкого уровня.Кредитный скоринг
        {
            List<string> borrowers = new List<string> { "Иванов", "Васильев" };
            List<int> rates = new List<int> { 25, 85 };

            List<string> solventBorrowers = GetSolventBorrowers(borrowers, rates);

            foreach (string borrower in solventBorrowers)
            {
                Console.WriteLine(borrower);
            }
        }

        static List<string> GetSolventBorrowers(List<string> borrowers, List<int> rates) //11.3 Задачи легкого уровня.Кредитный скоринг
        {
            List<string> res = new List<string>();
            for (int i = 0; i < rates.Count; i++)
            {
                if (rates[i] > 75)
                    res.Add(borrowers[i]);
            }
            return res;
        }

        static void Task_base_11_3_6() //11.3 Задачи легкого уровня.Криптография
        {
            int number = 120;
            List<int> primeDivisors = GetPrimeDivisors(number);
            Console.WriteLine(string.Join(" ", primeDivisors));
        }


        static List<int> GetPrimeDivisors(int n) //11.3 Задачи легкого уровня.Криптография
        {
            List<int> res = new List<int>();
            int i = 1;
            while (n > 1)
            {
                i++;
                if (n % i == 0)
                {
                    bool simp = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0 && j != i)
                            simp = false;
                    }
                    if (simp)
                    {
                        res.Add(i);
                        n /= i;
                        i = 1;
                    }
                }
            }
            return res;
        }

        static List<string> GetStringList(int n) //11.3 Задачи легкого уровня.Чашки
        {
            List<string> strings = new List<string>();
            for (int i = 0; i < n; i++)
            {
                strings.Add(Console.ReadLine());
            }
            return strings;
        }
        static void Task_base_11_3_7() //11.3 Задачи легкого уровня.Чашки
        {
            int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
            List<string> oldBowls = GetStringList(n);
            int b = int.TryParse(Console.ReadLine(), out b) ? b : 0;
            int k = int.TryParse(Console.ReadLine(), out k) ? k : 0;
            List<string> newBowls = GetStringList(k);
            List<string> resBowls = oldBowls[0..^b];
            resBowls.AddRange(newBowls);
            foreach (string bowl in resBowls)
            {
                Console.WriteLine(bowl);
            }
            if (resBowls.Count < oldBowls.Count)
            {
                Console.WriteLine("Грустно!");
            }
            else
            {
                Console.WriteLine("Радостно!");
            }
        }

        static List<int> GetNumbers(string s)
        {
            List<int> Numbers = new List<int>();
            string tempSt = "";
            foreach (char c in s)
            {
                if (c >= '0' && c <= '9')
                    tempSt += c;
                else if (tempSt.Length > 0)
                {
                    Numbers.Add(int.Parse(tempSt));
                    tempSt = "";
                }
            }
            if (tempSt.Length > 0) Numbers.Add(int.Parse(tempSt));
            return Numbers;
        }

        static void Task_base_11_3_8() //11.3 Задачи легкого уровня.Плохая машинистка
        {
            string input = "77раз отмерь,1–отрежь11.3";
            List<int> numbers = GetNumbers(input);
            Console.WriteLine(string.Join(" ", numbers));
        }


        static void Task_base_11_4_1() //11.4 Задачи легкого уровня.Плохая машинистка
        {
            int k = int.TryParse(Console.ReadLine(), out k) ? k : 0;
            List<string> strings = new List<string>();
            for (int i = 0; i < k; i++)
            {
                strings.Add(Console.ReadLine());
            }
            int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
            int j = 0;
            k--;
            while (j < n)
            {
                Console.WriteLine(strings[k - j * 2]);
                j++;
            }
        }

        static List<int> Merge(List<int> list1, List<int> list2) //11.4 Задачи среднего уровня. Merge lists 1
        {
            List<int> listSumm = new List<int>();
            listSumm.InsertRange(0, list1);
            listSumm.InsertRange(list1.Count, list2);
            listSumm.Sort();
            return listSumm;
        }

        static void Task_base_11_4_2() //11.4 Задачи среднего уровня. Merge lists 1
        {
            List<int> list1 = new List<int>() { 1, 7, 10, 16 }; //{ 1, 2, 3 };
            List<int> list2 = new List<int>() { 5, 6, 13, 20 }; //{ 5, 6, 7, 8 };

            List<int> list = Merge(list1, list2);
            Console.WriteLine(string.Join(", ", list));
        }


        static List<int> MergeLists(List<List<int>> lists) //11.4 Задачи среднего уровня. Merge lists 2
        {
            List<int> merged = new List<int>();
            foreach (List<int> lst in lists)
            {
                lst.Sort();
                merged.InsertRange(merged.Count, lst);
            }
            return merged;
        }

        static void Task_base_11_4_3() //11.4 Задачи среднего уровня. Merge lists 2
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4 };
            List<int> list2 = new List<int> { 5, 6, 7 };
            List<int> list3 = new List<int> { 10, 17, 11 };

            List<List<int>> allLists = new List<List<int>> { list1, list2, list3 };

            List<int> merged = MergeLists(allLists);

            Console.WriteLine(string.Join(" ", merged));
        }


        static List<string> GetDaysStatistics(List<string> friendWeekdays) //11.4 Задачи среднего уровня. Хотим "посидеть"
        {
            string[] friendDays = new string[7];
            int[] countByDay = new int[7];
            List<string> weekDays = new List<string>()
            {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
            foreach (string friend in friendWeekdays)
            {
                friendDays = friend.Split(' ');
                foreach (string day in friendDays)
                {
                    int i = weekDays.IndexOf(day);
                    if (i > -1) countByDay[i]++;
                }
            }

            List<string> result = new List<string>();
            for (int i = 0; i < weekDays.Count; i++)
            {
                if (countByDay[i] > 0)
                {
                    result.Add($"{weekDays[i]} {countByDay[i]}");
                }
            }
            return result;
        }


        static void Task_base_11_4_4() //11.4 Задачи среднего уровня. Хотим "посидеть"
        {
            List<string> friendWeekdays = new List<string>
            {
                "понедельник среда",
                "четверг пятница понедельник"
            };

            List<string> result = GetDaysStatistics(friendWeekdays);

            foreach (var line in result)
            {
                Console.WriteLine(line);
            }
        }


        static void Task_base_11_4_5() //11.4 Задачи среднего уровня. Задача Иосифа Флавия
        {
            int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
            int k = int.TryParse(Console.ReadLine(), out k) ? k : 0;
            List<int> people = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                people.Add(i);
            }
            int j = (k - 1) % people.Count;
            while (people.Count > 1)
            {
                people.RemoveAt(j);
                j--;
                j += k;
                int over = people.Count - j;
                if (over <= 0) j = (over % people.Count) * -1;
            }
            Console.WriteLine(people[0]);
        }

        static List<List<string>> Chunked(List<string> list, int n) //11.5 Задачи повышенного уровня. Разбиение на чанки
        {
            List<List<string>> chunks = new List<List<string>>();
            for (int i = 0; i < list.Count; i += n)
            {
                int end = i + n;
                end = end > list.Count ? list.Count : end;
                List<string> temp = list[i..end];
                chunks.Add(temp);
            }
            return chunks;
        }

        static void Task_base_11_5_1() //11.5 Задачи повышенного уровня. Разбиение на чанки
        {
            List<string> input = new List<string> { "a", "b", "c", "d", "e", "f", "j" };
            int chunkSize = 2;

            List<List<string>> chunks = Chunked(input, chunkSize);

            Console.Write("[");
            for (int i = 0; i < chunks.Count; i++)
            {
                Console.Write("[");
                Console.Write("'" + string.Join("', '", chunks[i]) + "'");
                Console.Write("]");
                if (i != chunks.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }

        static List<List<string>> subLists(List<string> list) //11.5 Задачи повышенного уровня. Подсписки списка
        {
            List<List<string>> chunks = new List<List<string>>();
            for (int i = 0; i <= list.Count; i++)
            {
                List<string> temp = list[0..i];
                chunks.Add(temp);
            }
            return chunks;
        }

        static void Task_base_11_5_2() //11.5 Задачи повышенного уровня. Подсписки списка
        {
            string[] input = Console.ReadLine().Split(' ');
            List<string> list = new List<string>();
            list.InsertRange(0, input);
            List<List<string>> chunks = new List<List<string>>();
            for (int i = 1; i <= list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (j + i > list.Count) continue;
                    List<string> temp = list[j..(j + i)];
                    chunks.Add(temp);
                }
            }

            Console.Write("[");
            Console.Write("[], ");
            for (int i = 0; i < chunks.Count; i++)
            {
                Console.Write("[");
                Console.Write("'" + string.Join("', '", chunks[i]) + "'");
                Console.Write("]");
                if (i != chunks.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }


        static void Task_base_12_2_1() //12.2 Задачи базового уровня. Строка
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < n; i++)
                stack.Push(Console.ReadLine());
            Console.WriteLine(string.Join(' ', stack));
        }


        static void Task_base_12_2_2() //12.2 Задачи базового уровня. Выбор растений
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Stack<string> allPlants = new Stack<string>();
            List<string> unwantedPlants = new List<string> { "Алоэ", "Бегония", "Каланхоэ" };
            for (int i = 0; i < n; i++)
                allPlants.Push(Console.ReadLine());
            while (allPlants.Count > 0)
            {
                string plant = allPlants.Pop();
                if (!unwantedPlants.Contains(plant))
                    Console.WriteLine(plant);
            }
        }


        static void Task_base_12_2_3() //12.2 Задачи базового уровня. Нахождение элемента
        {
            string[] source = Console.ReadLine().Split(' ');
            string toFind = Console.ReadLine();
            Stack<string> stack = new Stack<string>();
            foreach (string v in source)
            {
                stack.Push(v);
            }
            Console.WriteLine(stack.Contains(toFind));
        }

        static void Task_base_12_2_4() //12.3 Задачи легкого уровня.Разворот массива
        {
            string[] source = Console.ReadLine().Split(' ');
            Stack<string> stack = new Stack<string>();
            foreach (string v in source)
            {
                if (stack.Count == 0)
                    stack.Push(v);
                else if (v != stack.Peek())
                    stack.Push(v);
            }
            Console.WriteLine(string.Join(' ', stack));
        }


        static void Task_base_12_2_5() //12.3 Задачи легкого уровня. Список покупок
        {
            Stack<string> stack = new Stack<string>();
            string input = Console.ReadLine();
            while (input != "Конец списка")
            {
                stack.Push(input);
                input = Console.ReadLine();
            }
            while (stack.Count > 0)
            {
                string purchase = stack.Pop();
                if (purchase == "+")
                {
                    if (stack.Count > 0) stack.Pop();
                    continue;
                }
                Console.WriteLine(purchase);
            }
        }

        public static void Task_base_12_4_1() //12.4 Задачи среднего уровня. Опечатки при вводе
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            int last = input.Length - 1;
            stack.Push(input[last]);
            for (int i = last; i >= 0; i--)
            {
                if (stack.Peek() != input[i]) stack.Push(input[i]);
            }
            Console.WriteLine(string.Join("", stack));
        }


        public static void Task_base_12_4_2() //12.4 Задачи среднего уровня. Правильная скобочная последовательность
        {
            string input = Console.ReadLine();
            Stack<char> brackets = new Stack<char>();
            bool closed = true;
            bool empty = string.IsNullOrEmpty(input);
            if (!empty)
            {
                empty = false;
                foreach (char c in input)
                {
                    if (c == '(') brackets.Push(c);
                    if (c == ')')
                    {
                        if (brackets.Count == 0)
                        {
                            closed = false;
                            break;
                        }
                        else brackets.Pop();
                    }
                }
                if (brackets.Count != 0) closed = false;
            }
            Console.WriteLine(closed || empty ? "YES" : "NO");
        }

        static void Task_base_12_4_3() //12.4 Задачи среднего уровня. Юный помощник
        {
            int n = Convert.ToInt32(Console.ReadLine()); // Общее количество тарелок
            Stack<string> plates = new Stack<string>();
            for (int i = 0; i < n; i++) plates.Push(Console.ReadLine());

            int k = Convert.ToInt32(Console.ReadLine()); // Количество тарелок в стопке

            Console.WriteLine("Все тарелки в одной стопке:");
            foreach (var v in plates) Console.WriteLine(v); // Вывод введёных тарелок
            Stack<string> rPlates = new Stack<string>(plates);

            Console.WriteLine("Оставшиеся тарелки в первоначальной стопке:");
            Stack<string> stopka = new Stack<string>();
            for (int i = 0; i < k; i++)
            {
                if (rPlates.Count > 0) stopka.Push(rPlates.Pop());
            }
            foreach (string plate in stopka) Console.WriteLine(plate);

            int counter = 0; // Дополнительные стопки
            stopka.Clear();
            while (plates.Count > k)
            {
                counter++;
                stopka.Push(plates.Pop());
                if (counter == k || plates.Count == k)
                {
                    Console.WriteLine("Новая стопка:");
                    foreach (string plate in stopka) Console.WriteLine(plate);
                    stopka.Clear();
                    counter = 0;
                }
            }
        }

        static void Task_base_12_4_3_right() //12.4 Задачи среднего уровня. Юный помощник
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var allPlates = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                allPlates.Push(Console.ReadLine());
            }
            int count = Convert.ToInt32(Console.ReadLine()); // Высота стопки
            Console.WriteLine("Все тарелки в одной стопке:");
            foreach (var plate in allPlates)
            {
                Console.WriteLine(plate);
            }

            var listStacks = new List<Stack<string>>();
            while (allPlates.Count > count)
            {
                var stack = new Stack<string>();
                while (stack.Count != count && allPlates.Count != count)
                {
                    stack.Push(allPlates.Pop());
                }
                listStacks.Add(stack);
            }
            Console.WriteLine("Оставшиеся тарелки в первоначальной стопке:");
            foreach (var plate in allPlates)
            {
                Console.WriteLine(plate);
            }

            foreach (var stack in listStacks)
            {
                Console.WriteLine("Новая стопка:");
                foreach (var plate in stack)
                {
                    Console.WriteLine(plate);
                }
            }
        }


        static void Task_base_12_4_4() //12.4 Задачи среднего уровня. Правильная скобочная последовательность-2
        {
            string input = Console.ReadLine();

            int brCount = 4;
            char[,] brTypes = new char[,]
            {
                {'(',')'},
                {'[',']'},
                {'{','}'},
                {'<','>'},
            };
            List<Stack<int>> brackets = new List<Stack<int>>()
            {
                new Stack<int>(),
                new Stack<int>(),
                new Stack<int>(),
                new Stack<int>(),
            };

            bool test = input != null;

            for (int k = 0; k < input.Length; k++)
            {
                for (int i = 0; i < brCount; i++)
                {
                    if (input[k] == brTypes[i, 0])
                    {
                        brackets[i].Push(k);
                        break;
                    }
                    else if (input[k] == brTypes[i, 1])
                    {
                        bool opened = brackets[i].Count > 0;
                        bool goodPos = true;
                        if (opened)
                        {
                            int pos = brackets[i].Pop();
                            for (int j = 0; j < brCount; j++)
                            {
                                if (i != j)
                                {
                                    if (brackets[j].Count > 0)
                                        goodPos &= pos > brackets[j].Peek();
                                }
                            }
                        }
                        test = goodPos && opened;
                        break;
                    }
                }
                if (!test) break;
            }
            int notClosed = 0;
            foreach (Stack<int> stack in brackets)
            {
                notClosed += stack.Count;
            }
            Console.WriteLine(test && notClosed == 0);
        }


        static void Task_base_12_4_4_right() //12.4 Задачи среднего уровня. Правильная скобочная последовательность-2
        {
            int brCount = 4;
            char[,] brTypes = new char[,]
            {
            {'(',')'},
            {'[',']'},
            {'{','}'},
            {'<','>'}
            };
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (char ch in input)
            {
                bool done = false;
                for (int i = 0; i < brCount; i++)
                    if (ch == brTypes[i, 0]) { done = true; stack.Push(ch); break; }
                if (!done)
                    for (int j = 0; j < brCount; j++)
                        if (ch == brTypes[j, 1])
                        {
                            if (stack.Count == 0) { stack.Push('!'); break; }
                            if (stack.Peek() == brTypes[j, 0]) { done = true; stack.Pop(); break; }
                        }
                if (!done) break;
            }
            Console.WriteLine(stack.Count == 0);
        }


        static void Task_base_13_2_4() //13.2 Задачи базового уровня. Заполни очередь
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Queue<string> que = new Queue<string>();
            for (int i = 0; i < n; i++)
            {
                que.Enqueue(Console.ReadLine());
            }
            Console.WriteLine(string.Join(' ', que));
        }


        static void Task_base_13_2_5() //13.2 Задачи базового уровня. Эстафета
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Queue<string> teem1 = new Queue<string>();
            for (int i = 0; i < n; i++)
            {
                teem1.Enqueue(Console.ReadLine());
            }
            n = Convert.ToInt32(Console.ReadLine());
            Queue<string> teem2 = new Queue<string>();
            for (int i = 0; i < n; i++)
            {
                teem2.Enqueue(Console.ReadLine());
            }
            Console.WriteLine($"Всего {teem1.Count + teem2.Count} участников соревнования.");
            Console.WriteLine($"Открывающий первой команды {teem1.Peek()}, открывающий второй команды {teem2.Peek()}.");
        }


        static void Task_base_13_2_6() //13.2 Задачи базового уровня. STOP
        {
            Queue<string> que = new Queue<string>();
            string input = Console.ReadLine();
            while (input != "stop")
            {
                que.Enqueue(input);
                input = Console.ReadLine();
            }
            Console.WriteLine(que.Count());
            Console.WriteLine(string.Join(' ', que));
        }

        static void Task_base_13_2_7() //13.2 Задачи базового уровня. Чет нечет
        {
            string[] input = Console.ReadLine().Split(' ');
            Queue<int> odd = new Queue<int>();
            Queue<int> even = new Queue<int>();
            foreach (string st in input)
            {
                int n = Convert.ToInt32(st);
                if (n % 2 == 0) odd.Enqueue(n);
                else even.Enqueue(n);
            }
            foreach (int num in odd) Console.WriteLine(num);
            foreach (int num in even) Console.WriteLine(num);
        }


        static void Task_base_13_3_1() //13.3 Задачи легкого уровня. Игра в пьяницу
        {
            string[] input = Console.ReadLine().Split(' ');
            Queue<int> koloda = new Queue<int>();

            foreach (string st in input) koloda.Enqueue(Convert.ToInt32(st));

            Queue<int> player1 = new Queue<int>();
            Queue<int> player2 = new Queue<int>();
            //Раздача карт
            bool turnP1 = true;
            while (koloda.Count > 0)
            {
                if (turnP1) player1.Enqueue(koloda.Dequeue());
                else player2.Enqueue(koloda.Dequeue());
                turnP1 = !turnP1;
            }
            //Игра
            while (player1.Count > 0 && player2.Count > 0)
            {
                int card1 = player1.Dequeue();
                int card2 = player2.Dequeue();
                Console.WriteLine($"Игрок1 {card1} Игрок2 {card2}");

                if (card1 == 0 && card2 == 9)
                {
                    player1.Enqueue(card1);
                    player1.Enqueue(card2);
                }
                else if (card2 == 0 && card1 == 9)
                {
                    player2.Enqueue(card2);
                    player2.Enqueue(card1);
                }
                else if (card1 > card2)
                {
                    player1.Enqueue(card1);
                    player1.Enqueue(card2);
                }
                else
                {
                    player2.Enqueue(card2);
                    player2.Enqueue(card1);
                }
            }
            Console.WriteLine(player1.Count == 0 ? "Игрок2" : "Игрок1");
        }

        static void Task_base_13_3_2() //13.3 Задачи легкого уровня. Очередь в поликлинике
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Queue<string> patient = new Queue<string>();
            // Пациенты получают талончики
            for (int i = 0; i < n; i++)
            {
                patient.Enqueue(Console.ReadLine());
            }
            int m = Convert.ToInt32(Console.ReadLine());
            Queue<string> window = new Queue<string>();
            // Окошки получают пациентов
            for (int j = 0; j < m; j++)
            {
                string pt = patient.Count > 0 ? patient.Dequeue() : "";
                window.Enqueue(pt);
            }
            //Вывод окошек
            int win = 1;
            foreach (string pt in window)
            {

                if (pt == "")
                    Console.WriteLine($"Окно {win} свободно");
                else
                    Console.WriteLine($"Клиент {pt} --> Окно {win}");
                win++;
            }
            //Вывод пациентов
            foreach (string pt in patient)
            {
                Console.WriteLine($"Клиент {pt} остается ждать");
            }

        }


        static void Task_base_13_4_1() //13.4 Задачи среднего уровня. Коммутатор
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Queue<string> in_packs = new Queue<string>();
            for (int i = 0; i < n; i++) in_packs.Enqueue(Console.ReadLine());

            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m; i++) in_packs.Enqueue(Console.ReadLine());

            int t = Convert.ToInt32(Console.ReadLine());
            List<Queue<string>> Commutator = new List<Queue<string>>()
            {
                new Queue<string> (),
                new Queue<string> (),
                new Queue<string> (),
                new Queue<string> (),
                new Queue<string> (),
                new Queue<string> (),
                new Queue<string> (),
                new Queue<string> ()
            };

            foreach (string pack in in_packs)
            {
                string mark = pack.Split(' ')[^1];
                switch (mark)
                {
                    case "VL8":
                        Commutator[0].Enqueue(pack);
                        break;
                    case "VL10":
                        Commutator[1].Enqueue(pack);
                        Commutator[2].Enqueue(pack);
                        Commutator[3].Enqueue(pack);
                        break;
                    case "VL12":
                        Commutator[4].Enqueue(pack);
                        Commutator[5].Enqueue(pack);
                        break;
                    default:
                        Commutator[6].Enqueue(pack);
                        Commutator[7].Enqueue(pack);
                        break;
                }
            }
            Console.WriteLine($"На порт {t} прилетело {Commutator[t].Count} пакетов:");
            foreach (string pack in Commutator[t]) Console.WriteLine(pack);
        }


        static void Task_base_13_4_2() //13.4 Задачи среднего уровня. Мальчики и девочки
        {
            string input_kids = Console.ReadLine();
            Queue<string> kids = new Queue<string>(input_kids.Split(' '));
            string input_plates = Console.ReadLine();
            Queue<string> plates = new Queue<string>(input_plates.Split(' '));
            bool stop = false;
            while (plates.Count > 0 && kids.Count > 0 && !stop)
            {
                string plate = plates.Peek();
                string kid = kids.Peek();
                if (kid == plate)
                {
                    plates.Dequeue();
                    kids.Dequeue();
                }
                else
                {
                    if (kids.Contains(plate))
                        kids.Enqueue(kids.Dequeue());
                    else stop = true;
                }
            }
            Console.WriteLine(kids.Count);
        }

        static void Task_base_14_2_7() //14.2 Задачи базового уровня. Элементы
        {
            HashSet<string> hst = new HashSet<string>();
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++) hst.Add(Console.ReadLine());
            Console.WriteLine(string.Join("***", hst));
        }

        static void Task_base_14_2_8() //14.2 Задачи базового уровня. Совпадение
        {
            HashSet<string> angelina = new HashSet<string>();
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++) angelina.Add(Console.ReadLine());

            HashSet<string> ulia = new HashSet<string>();
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m; i++) ulia.Add(Console.ReadLine());

            angelina.IntersectWith(ulia);

            foreach (string s in angelina) Console.WriteLine(s);
        }


        static void Task_base_14_2_9() //14.2 Задачи базового уровня. Уникальный
        {
            string input_str1 = Console.ReadLine();
            HashSet<string> str1 = new HashSet<string>(input_str1.Split(' '));
            string input_str2 = Console.ReadLine();
            HashSet<string> str2 = new HashSet<string>(input_str2.Split(' '));
            str1.ExceptWith(str2);
            foreach (string s in str1) Console.WriteLine(s);
        }

        static void Task_base_14_3_1() //14.3 Задачи легкого уровня. Список курсов 2
        {
            HashSet<string> fact = new HashSet<string>();
            int n_fact = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n_fact; i++)
                fact.Add(Console.ReadLine());

            HashSet<string> plan = new HashSet<string>();
            int m_plan = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m_plan; i++)
                plan.Add(Console.ReadLine());

            foreach (string st in plan)
                if (fact.Contains(st))
                    Console.WriteLine("YES");
                else Console.WriteLine("NO");
        }


        static void Task_base_14_3_2() //14.3 Задачи легкого уровня.Тимур и Артур
        {
            HashSet<string> cities = new HashSet<string>();
            int n_city = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n_city; i++)
                cities.Add(Console.ReadLine());
            if (cities.Add(Console.ReadLine()))
                Console.WriteLine("OK");
            else
                Console.WriteLine("EXIST");
        }

        static void Task_base_14_3_3() //14.3 Задачи легкого уровня. Однофамильцы
        {
            List<string> students = new List<string>();
            int n_students = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n_students; i++)
                students.Add(Console.ReadLine());

            HashSet<string> students_unic = new HashSet<string>(students);
            int same_name = 0;
            foreach (string name in students_unic)
            {
                int index = 0;
                int counter = 0;
                while (true)
                {
                    index = students.IndexOf(name);
                    if (index == -1) break;
                    counter++;
                    students.RemoveAt(index);
                }
                if (counter > 1) same_name += counter;
            }
            Console.WriteLine(same_name);
        }


        static void Task_base_14_4_1() //14.4 Задачи среднего уровня. Ученики онлайн-школы 
        {
            HashSet<string> csh = new HashSet<string>();
            int n_stud_csh = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n_stud_csh; i++)
                csh.Add(Console.ReadLine());

            HashSet<string> kotlin = new HashSet<string>();
            int n_stud_kotlin = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n_stud_kotlin; i++)
                kotlin.Add(Console.ReadLine());

            HashSet<string> both = new HashSet<string>(csh);
            both.IntersectWith(kotlin);

            int res = csh.Count + kotlin.Count - both.Count * 2;
            Console.WriteLine(res > 0 ? res.ToString() : "NO");
        }

        static void Task_base_14_4_2() //14.4 Задачи среднего уровня. Тетради учеников
        {
            List<HashSet<string>> all_ntb = new List<HashSet<string>>();
            int n_subj = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n_subj; i++)
            {
                all_ntb.Add(new HashSet<string>());
                int n_stud = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < n_stud; j++)
                {
                    all_ntb[all_ntb.Count - 1].Add(Console.ReadLine());
                }
            }
            HashSet<string> resultSet = new HashSet<string>(all_ntb[0]);
            foreach (var hash in all_ntb)
            {
                resultSet.IntersectWith(hash);
            }
            Console.WriteLine(resultSet.Count);
        }

        static void Task_base_15_2_5() //15.2 Задачи базового уровня.Пары
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> prediction = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                prediction.Add(input[0], input[1]);
            }
            foreach (var pair in prediction)
            {
                Console.WriteLine($"Ключ: {pair.Key}, значение: {pair.Value}");
            }
        }


        public static void Task_base_15_2_6() //15.2 Задачи базового уровня.Вывод значения
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> dict = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                dict.Add(input[0], input[1]);
            }
            string key = Console.ReadLine();
            if (dict.ContainsKey(key)) Console.WriteLine(dict[key]);
        }

        static void Task_base_15_2_7() //15.2 Задачи базового уровня. Продукты 
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> grocery = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                grocery.Add(input[0], int.Parse(input[1]));
            }

            int limit = 500;
            foreach (var product in grocery)
                if (product.Value < limit) Console.WriteLine(product.Key);
        }

        static void Task_base_15_2_8() //15.2 Задачи базового уровня. Объединение словарей
        {
            // Словарь 1
            Dictionary<int, string> dictionary1 = new Dictionary<int, string>()
            {
                [1] = "Val1",
                [3] = "Val3",
                [5] = "Val5"
            };

            // Словарь 2
            Dictionary<int, string> dictionary2 = new Dictionary<int, string>()
            {
                [1] = "Val11",
                [2] = "Val2",
                [4] = "Val4"
            };

            // Объединение словарей
            Dictionary<int, string> combinedDictionary = CombineDictionaries(dictionary1, dictionary2);

            // Вывод результата
            foreach (var item in combinedDictionary)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }


        static Dictionary<int, string> CombineDictionaries(Dictionary<int, string> dict1, Dictionary<int, string> dict2)
        {
            Dictionary<int, string> combo = new Dictionary<int, string>();

            foreach (var pair in dict1)
                combo.Add(pair.Key, pair.Value);

            foreach (var pair in dict2)
                combo.TryAdd(pair.Key, pair.Value);

            return combo;
        }

        static void Task_base_15_2_9() //15.2 Задачи базового уровня. Jingle Bells
        {
            Dictionary<string, int> products = new Dictionary<string, int>
            {
                { "Гирлянда", 1350 },
                { "Снежинки", 670 },
                { "Мишура", 780 },
                { "Подсвечник", 480 },
                { "Свечи", 670 },
                { "Дождик", 1200 }
            };

            Console.WriteLine(CalculateTotal(products));
        }

        static int CalculateTotal(Dictionary<string, int> products)
        {
            int summ = 0;
            foreach (var v in products) { summ += v.Value; }

            return summ;
        }

        static void Task_base_15_2_10() //15.2 Задачи базового уровня. ВЕРХНИЙ РЕГИСТР
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                { "ID25489472", "Петров" },
                { "№0374", "мовсгу" },
                { "Дисплей", "oled" }
            };

            foreach (var pair in ConvertValuesToUpper(dict))
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
        }

        static Dictionary<string, string> ConvertValuesToUpper(Dictionary<string, string> dict)
        {
            foreach (var pair in dict)
            {
                dict[pair.Key] = pair.Value.ToUpper();
            }
            return dict;
        }


        static void Task_base_15_3_1() //15.2 Задачи базового уровня. Словарь синонимов
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> vacabluary = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                vacabluary.Add(input[0], input[1]);
                vacabluary.Add(input[1], input[0]);
            }

            string reqwest = Console.ReadLine();
            string result = "Unknown word.";
            if (vacabluary.ContainsKey(reqwest))
                result = vacabluary[reqwest];

            Console.WriteLine(result);
        }

        static void Task_base_15_3_2() //15.2 Задачи базового уровня. Страны и города
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> cites = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 1; j < input.Length; j++)
                    cites.Add(input[j], input[0]);
            }

            n = int.Parse(Console.ReadLine());
            string[] reqwests = new string[n];
            for (int i = 0; i < n; i++)
            {
                reqwests[i] = Console.ReadLine();
            }

            foreach (var reqwest in reqwests)
            {
                string result = "Unknown city.";
                if (cites.ContainsKey(reqwest))
                    result = cites[reqwest];
                Console.WriteLine(result);
            }
        }


        static void Task_base_15_3_3() //15.2 Задачи базового уровня. Исправление дубликатов
        {
            string[] input = Console.ReadLine().Split(' ');
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] result = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                string s = input[i];
                if (!dict.ContainsKey(s))
                {
                    dict.Add(s, 0);
                    result[i] = s;
                }
                else
                {
                    dict[s]++;
                    result[i] = $"{s}_{dict[s]}";
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }


        static void Task_base_15_3_4() //15.2 Задачи базового уровня. Хотим "посидеть" 2
        {
            Dictionary<string, int> week = new Dictionary<string, int>()
            {
                {"пн", 0},
                {"вт", 0},
                {"ср", 0},
                {"чт", 0},
                {"пт", 0},
                {"сб", 0},
                {"вс", 0}
            };
            int fr = int.Parse(Console.ReadLine());
            for (int i = 0; i < fr; i++)
            {
                string[] frDays = Console.ReadLine().Split(' ');
                foreach (var day in frDays)
                    week[day]++;
            }

            foreach (var day in week)
                if (day.Value > 0)
                    Console.WriteLine($"{day.Key} {day.Value}");
        }
        static void Task_base_15_3_5() //15.2 Задачи базового уровня. Мотивация
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> dayList = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] student1 = Console.ReadLine().Split(' ');
                dayList.Add(student1[0], int.Parse(student1[1]));
            }
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] student2 = Console.ReadLine().Split(' ');
                if (dayList.ContainsKey(student2[0]))
                    dayList[student2[0]] += int.Parse(student2[1]);
                else
                    dayList.Add(student2[0], int.Parse(student2[1]));
            }

            foreach (var student in dayList)
                Console.WriteLine($"Студент {student.Key} решил(а) {student.Value} задач");
        }


        static void Task_base_15_3_6() //15.2 Задачи базового уровня. Анаграммы 1
        {
            string wFw = Console.ReadLine();
            string wBw = Console.ReadLine();
            if (wFw.Length != wBw.Length)
            {
                Console.WriteLine("NO");
                return;
            }
            Dictionary<int, char> anagramm = new Dictionary<int, char>();
            for (int i = 0; i < wFw.Length; i++)
            {
                anagramm.Add(i, wFw[i]);
            }
            foreach (var c in wBw)
            {
                if (anagramm.ContainsValue(c))
                {
                    foreach (var rec in anagramm)
                    {
                        if (rec.Value == c)
                        {
                            anagramm.Remove(rec.Key);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }


        static void Task_base_15_3_7() //15.2 Задачи базового уровня. Первичная обработка текстов LLM
        {
            string[] input = Console.ReadLine().ToLower().Split(' ');
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string s in input)
            {
                if (dict.ContainsKey(s))
                    dict[s]++;
                else
                    dict.Add(s, 1);
                Console.Write(dict[s].ToString() + ' ');
            }
        }
    }
}