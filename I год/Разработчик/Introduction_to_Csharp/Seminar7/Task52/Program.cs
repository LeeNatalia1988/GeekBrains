void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
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
void ArithmeticMean (int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double ArMean = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
            ArMean += matrix[i,j];
        ArMean = ArMean/matrix.GetLength(0);
        Console.WriteLine($"Среднее арифметическое {j+1}-го столбца: {Math.Round(ArMean, 2)}");
    }
}
Console.Clear();
Console.Write("Введите размеры массива через пробел (количество строк количество столбцов): ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив");
PrintMatrix(matrix);
ArithmeticMean(matrix);


