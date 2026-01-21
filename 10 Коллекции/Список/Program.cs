using System.Collections.Generic;
namespace Список
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_base_11_2_1(); //Заполни список
        }


        static void Task_base_11_2_1() //Заполни список
        {
            int n = int.TryParse(Console.ReadLine(), out n)?n:0; //количество элементов в списке
            List<string> strings = new List<string>();
            for (int i = 0; i < n; i++)
            {
                strings.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",strings));
        }
    }
}
