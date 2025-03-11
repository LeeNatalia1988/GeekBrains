//OK
void InputMatrix(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, matrix.GetLength(1) / 2 - i] = matrix[i, matrix.GetLength(1) / 2 + i] = 1;
    }
    for (int i = 2; i < matrix.GetLength(0); i++)
    {
        for (int j = 2; j < matrix.GetLength(1) - 1; j++)
        if (matrix[i,j] != 1)
            matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j + 1];
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        if (matrix[i,j] != 0)
            Console.Write($"{matrix[i, j]} \t");
        else Console.Write($"\t");
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[n, 2 * n - 1];
matrix[0, matrix.GetLength(1) / 2] = 1;
Console.WriteLine($"Первые {n} строк треугольника Паскаля: ");
InputMatrix(matrix);
PrintMatrix(matrix);
