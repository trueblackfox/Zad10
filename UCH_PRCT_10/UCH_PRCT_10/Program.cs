using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCH_PRCT_10
{
    class Program
    {
        private static int[] Posl;
        private static int n;
        private static void CreatePosl()
        {
            void CheckInt(string message, out int res)
            {
                bool check; // отвечает за проверку типа переменной
                Console.Write(message);
                do
                {
                    string prior = Console.ReadLine();
                    check = Int32.TryParse(prior, out res);
                    if (check == false) Console.WriteLine("Неправильный ввод, попробуйте ещё раз.");
                } while (check == false);
            } // Проверка входных данных на соответствие типу Int

            do
            {
                CheckInt("\n Введите количество чисел в последовательности : ", out n);
                if (n < 2) Console.WriteLine("Ошибка ввода! ");
            } while (n < 2);
            Posl = new int[n];
            int a;
            for (int i = 0; i < n; i++)
            {
                Console.Clear();
                CheckInt("\n Введите " + (i + 1) + " число последовательности:  ", out a);
                Posl[i] = a;
            }
        }

        private static void PrintPosl()
        {
            for (int i = 0; i < n - 1; i++)
                Console.WriteLine(" " + Posl[i]);
        }
        private static void UpdatePosl()
        {
            for (int i = 0; i < n - 1; i++)
                Posl[i] = Posl[i] - Posl[n - 1];
        }
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Даны натуральное число n, действительные числа x_1,…,x_n(n≥2). Получить последовательность x_1-x_n,…,x_(n-1)-x_n.");
            Console.ResetColor();
            CreatePosl();
            UpdatePosl();


            Console.WriteLine("\n Ваша новая последовательность выглядит так: ");
            PrintPosl();
            Console.ReadKey();

        }

    }

}
