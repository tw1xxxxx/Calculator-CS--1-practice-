using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string a = " ";
        static int b=0, c = 0;
        int[] array1 = { };
        int[] array2 = { };


        static void Main()
        {
            //for (int i =0; i > length; )
            Console.WriteLine("Введи число ");
            string txt = Console.ReadLine();
            Console.WriteLine("Введи знак ");
            a = Console.ReadLine();
            Console.WriteLine("Введи число ");
            while (int.TryParse(txt, out b))
            {
                int[] array1 = {};
                int[] array2 = {};

            }
            Console.ReadLine();
                if (a == "-")
            {
                Console.WriteLine(b - c);
            }
           
            if (a == "+")
            {
                Console.WriteLine(b + c);
            }
            
            if (a == "*")
            {
                Console.WriteLine(b * c);
            }
            if (a == "/")
            {
                Console.WriteLine(b / c);
            }
            Console.ReadKey();
        }
    }
}
