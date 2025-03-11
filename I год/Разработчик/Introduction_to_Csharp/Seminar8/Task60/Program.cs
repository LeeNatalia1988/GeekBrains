//ОК
void InputMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j, k] = new Random().Next(10, 101);
        }
    }
}
void Check(int[,,] matrix)
{
    int count = 0;
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int a = 0; a < matrix.GetLength(2); a++)
                {
                    for (int b = 0; b < matrix.GetLength(0); b++)
                    {
                        for (int c = 0; c < matrix.GetLength(1); c++)
                        {
                            if (matrix[i, j, k] == matrix[b, c, a])
                                count++;
                        }
                    }
                }
            
            }
            
        }
    }
    if (count > matrix.GetLength(0)*matrix.GetLength(1)*matrix.GetLength(2))
    {
        InputMatrix(matrix);
        Check(matrix);
        Console.WriteLine("Обнаружены равные элементы! Ищем новые.");
    }
}
void PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}
Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[size[0], size[1], size[2]];
InputMatrix(matrix);
Check(matrix);
Console.WriteLine();
Console.WriteLine("Полученная матрица: ");
PrintMatrix(matrix);
