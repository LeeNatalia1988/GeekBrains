//OK
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
}
void Multiplication(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int Summ = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] = Summ + matrix1[i, k] * matrix2[k, j];
                Summ = matrix3[i, j];
            }
        }
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
Console.Clear();
Console.Write("Введите размеры матриц: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size[0], size[1]];
int[,] matrix2 = new int[size[1], size[0]];
int[,] matrix3 = new int[size[0], size[0]];
InputMatrix(matrix1);
InputMatrix(matrix2);
Console.WriteLine("Заданные матрицы: ");
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
Console.WriteLine("Матрица, которая является результатом умножения двух заданных матриц: ");
Multiplication(matrix1, matrix2, matrix3);
PrintMatrix(matrix3);
