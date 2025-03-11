void InputArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(new Random().NextDouble() * (100 + 100) - 100, 2);
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
void FindNumber(double[,] array, int[] indexes)
{
    if (indexes[0] > array.GetLength(0) || indexes[1] > array.GetLength(1))
        Console.WriteLine("Такой позиции нет!");
    else
    {
        int i = indexes[0] - 1;
        int j = indexes[1] - 1;
        Console.WriteLine($"Искомый элемент массива: {array[i,j]}");
    }
}
Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[,] array = new double[m, n];
InputArray(array);
Console.WriteLine($"Массив случайных вещественных чисел заданного размера: ");
PrintArray(array);
Console.WriteLine("Введите индексы искомого числа через пробел: ");
int[] indexes = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
FindNumber(array, indexes);