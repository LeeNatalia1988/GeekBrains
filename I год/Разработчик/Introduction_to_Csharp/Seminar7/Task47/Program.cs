void InputArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        array[i,j] = Math.Round(new Random().NextDouble() * (100 + 100) - 100, 2);
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[,] array = new double[m,n];
InputArray(array);
Console.WriteLine($"Массив случайных вещественных чисел заданного размера: ");
PrintArray(array);