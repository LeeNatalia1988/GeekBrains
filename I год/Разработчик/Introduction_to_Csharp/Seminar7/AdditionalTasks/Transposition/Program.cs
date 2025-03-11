//OK
void InputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-100, 101);
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}
void Transposition(int[,] array, int N)
{
    if (N % 2 == 0)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(0) / 2; i++)
            {
                int Element = array[i,j];
                array[i,j] = array[array.GetLength(0) - 1 - i,j];
                array[array.GetLength(0) - 1 - i,j] = Element;
            }
        }
    }
    else
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(0) / 2 + 1; i++)
            {
                int Element = array[i,j];
                array[i,j] = array[array.GetLength(0) - 1 - i,j];
                array[array.GetLength(0) - 1 - i,j] = Element;
            }
        }
    }
}
Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int M = int.Parse(Console.ReadLine()!);
int[,] array = new int[N,M];
InputArray(array);
Console.WriteLine($"Массив случайных чисел заданного размера: ");
PrintArray(array);
Transposition(array, N);
Console.WriteLine($"Массив после транспортирования по горизонтали: ");
PrintArray(array);