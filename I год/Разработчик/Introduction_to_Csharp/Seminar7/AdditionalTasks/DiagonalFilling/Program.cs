//OK
int InputArray1(int[,] array, int j, int Number)
{
    for (int i = 0; i < array.GetLength(0) && j >= 0; i++)
    {
        array[i, j] = Number;
        Number++;
        j--;
    }
    return Number;
}
int InputArray2(int[,] array, int j, int Number)
{
    for (int i = array.GetLength(0) - 1; i > 0 && j < array.GetLength(1) && j > 0; i--)
    {
        if (array[i,j] == 0)
        {
            array[i,j] = Number;
            Number--;
            j++;
        }
        else break;
    }
    return Number;
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
Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int m = int.Parse(Console.ReadLine()!);
int[,] array = new int[n, m];
array[n - 1, m - 1] = n * m - 1;
int j = 1;
int Number = 1;
for (j = 1; j < array.GetLength(1); j++)
{
    InputArray1(array, j, Number);
    Number = InputArray1(array, j, Number);
}
j = array.GetLength(1) - 2;
Number = n * m - 2;
for (j = array.GetLength(1) - 2; j < array.GetLength(1) && j > 0; j--)
{
    Number = InputArray2(array, j, Number);
    InputArray2(array, j, Number);
}
Console.WriteLine($"Заполненный массив: ");
PrintArray(array);

