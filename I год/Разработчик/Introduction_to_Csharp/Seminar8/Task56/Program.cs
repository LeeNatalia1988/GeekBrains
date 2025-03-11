//OK
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
    }
}
void Minimum(int[,] matrix)
{
    int Summ = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        Summ = Summ + matrix[0, j];
    int Number = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int SummLine = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SummLine = SummLine + matrix[i, j];
        }
        if (SummLine <= Summ)
        {
            Summ = SummLine;
            Number = i;
        }
    }
    Console.WriteLine(Number + 1);
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размеры прямойгольного двумерного массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
while (size[0] <= size[1])
{
    Console.Write("Вы ошиблись!\nВведите размеры прямоугольного двумерного массива: ");
    size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Заданная матрица: ");
PrintMatrix(matrix);
Console.Write("Номер строки с наименошей суммой элементов: ");
Minimum(matrix);
