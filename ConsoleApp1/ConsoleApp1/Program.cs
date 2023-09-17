using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
class Program
{

    static void Main()
    {
        List<int> arr = new List<int>();
        List<string> err = new List<string>();
        Console.WriteLine("Вас приветствует Практическая работа 1");
        Console.WriteLine("Это небольшой словарь калькулятора:");
        Console.ReadKey();
        Console.WriteLine("(+) - Прибавить.");
        Console.WriteLine("(-) - Отнять.");
        Console.WriteLine("(*) - Умножить.");
        Console.WriteLine("(/) - Разделить.");
        Console.WriteLine("(sqrt) - Найти квадратный корень.");
        Console.WriteLine("(**arg) - Возвести в степень.");
        Console.WriteLine("(%%arg) - Найти процент от числа.");
        Console.WriteLine("(!) - Факториал.");
        Console.WriteLine("Введите удобное число-команду для вывода результата");
        int stop = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("- Результат.");
        int result = 0;
        int a = 0;
        while (a != stop)
        {
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            arr.Add(a);
            Console.WriteLine("Введите знак");
            if(a != stop) {
                string b = Convert.ToString(Console.ReadLine());
                err.Add(b);
            }
        }
        for (var i = 0; i != arr.Count-1; i++)
        {
            if (err[i] == "+")
            {
                result += arr[i];
            }
            else if (err[i] == "-")
            {
                result -= arr[i];
            }
            else if (err[i] == "*")
            {
                result *= arr[i];
            }
            else if (err[i] == "/")
            {
                result = arr[i] / arr[i+1];
            }
        }    
        Console.WriteLine(result);
        Console.ReadKey();
    }
}
