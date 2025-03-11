//OK
int InputMatrix(int[,] matrix, int Number, int n, int Count)
{
    for (int j = n; j < matrix.GetLength(1) - n; j++)
    {
        matrix[n, j] = Number;
        Number++;
    }
    for (int i = (n + 1); i < matrix.GetLength(0) - (n + 1); i++)
    {
        matrix[i, matrix.GetLength(1) - (n + 1)] = Number;
        Number++;
    }
    for (int j = matrix.GetLength(1) - (n + 1); j > n; j--)
    {
        matrix[matrix.GetLength(0) - (n + 1), j] = Number;
        Number++;
    }
    if (n == 0)
    {
        for (int i = matrix.GetLength(0) - (n + 1); i > 0; i--)
        {
            matrix[i, n] = Number;
            Number++;
        }
    }
    else
    {
        for (int i = matrix.GetLength(0) - (n + 1); i > n; i--)
        {
            matrix[i, n] = Number;
            Number++;
        }
    }
    if (matrix.GetLength(0) % 2 != 0)
        matrix[matrix.GetLength(0) / 2, matrix.GetLength(1) / 2] = Count;
    if (Number <= Count && n < matrix.GetLength(0) / 2 - 1)
        return InputMatrix(matrix, Number, n + 1, Count);
    else return PrintMatrix(matrix);
}
int PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
    return 1;
}
Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int Count = size[0] * size[1];
int Number = 1;
int n = 0;
Console.WriteLine("Полученная матрица: ");
InputMatrix(matrix, Number, n, Count);