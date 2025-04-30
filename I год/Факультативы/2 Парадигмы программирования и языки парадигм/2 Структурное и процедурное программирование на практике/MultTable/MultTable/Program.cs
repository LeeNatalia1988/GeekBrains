namespace MultTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Выбрала процедурное, так как считаю так удобнее, нагляднее и методы могут быть переиспользованы при необходимости
            View();
        }

        static void View()
        {
            bool input = true;
            Console.WriteLine("Введите цифру или число или 0 для выхода: ");
            while (input)
            {
                if (Int32.TryParse(Console.ReadLine(), out int n))
                    if (n != 0)
                    {
                        PrintResult(Mult(n));
                        Console.WriteLine("***************************************");
                    }
                    else
                    {
                        Console.WriteLine("До свидания!");
                        input = false;
                    }
                else
                {
                    Console.WriteLine("Вы ввели неверный формат данных: ");
                }
            }
        }

        static string[,] Mult(int n)
        {
            string[,] result = new string[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i,j] = (i + 1).ToString() + " * " + (j + 1).ToString() + " = " + ((i + 1) * (j + 1)).ToString();
                }
            }
            return result;
        }

        static void PrintResult(string[,] result)
        {
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[j,i] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
