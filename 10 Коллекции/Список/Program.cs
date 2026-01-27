using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Список
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
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
                //Task_base_12_2_4(); //12.3 Задачи легкого уровня.Разворот массива
                //Task_base_12_2_5(); //12.3 Задачи легкого уровня. Список покупок
                //Task_base_12_4_1(); //12.4 Задачи среднего уровня. Опечатки при вводе
                //Task_base_12_4_2(); //12.4 Задачи среднего уровня. Правильная скобочная последовательность
                //Task_base_12_4_3(); //12.4 Задачи среднего уровня. Юный помощник
                Task_base_12_4_3_right(); //12.4 Задачи среднего уровня. Юный помощник
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
                if (rPlates.Count>0) stopka.Push(rPlates.Pop());
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

    }
}
