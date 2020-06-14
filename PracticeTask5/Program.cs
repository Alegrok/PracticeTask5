using System;

namespace PracticeTask5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в приложение по нахождению максимального элемента в заданной области (песочные часы)!");

            // Ввод размерности матрицы
            Console.WriteLine("\nВведите размерность матрицы:");
            int n = Input(1, 100);

            // Создание матрицы
            double[,] array = CreateMatrix(n);

            // Отображение матрицы
            Console.WriteLine("\nМатрица:");
            ShowMatrix(array);

            // Нахождение максимума в заданной области и его отображение
            double max = FindMax(array);
            Console.WriteLine("\nМаксимальный элемент: " + max);

            Console.WriteLine("\nЗавершение работы в приложении по нахождению максимального элемента в заданной области (песочные часы)");

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }

        // Нахождение максимума в заданной области
        public static double FindMax(double[,] array)
        {
            double max = array[0, 0];
            int size = (int)Math.Sqrt(array.Length);
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if (array[i, j] > max && (i == j || i + j == size - 1 || (j > i && i + j < size - 1) || (i > j && i + j > size - 1)))
                        max = array[i, j];
            return max;
        }

        // Создание матрицы
        public static double[,] CreateMatrix(int n)
        {
            double[,] array = new double[n, n];

            Console.WriteLine("\nВведите элементы матрицы");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Введите элемент {i + 1} строки и {j + 1} столбца");
                    array[i, j] = Input();
                }
                Console.WriteLine();
            }

            return array;
        }

        // Отображение матрицы
        private static void ShowMatrix(double[,] array)
        {
            for (int i = 0; i < (int)Math.Sqrt(array.Length); i++)
            {
                for (int j = 0; j < (int)Math.Sqrt(array.Length); j++)
                {
                    Console.Write((int)array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Ввод целого числа с ограничениями
        private static int Input(int min, int max)
        {
            int number;
            bool inputCheck;
            do
            {
                Console.Write("Ввод: ");
                inputCheck = int.TryParse(Console.ReadLine(), out number) && number >= min && number <= max;
                if (!inputCheck) Console.WriteLine($"Ошибка! Введите целое число в пределах от {min} до {max} (включительно)");
            } while (!inputCheck);
            return number;
        }

        // Ввод действительного числа
        private static double Input()
        {
            double number;
            bool inputCheck;
            do
            {
                Console.Write("Ввод: ");
                inputCheck = double.TryParse(Console.ReadLine(), out number);
                if (!inputCheck) Console.WriteLine("Ошибка! Введите действительное число");
            } while (!inputCheck);
            return number;
        }
    }
}
