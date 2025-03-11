//OK
void InputArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        string[] stroka = Console.ReadLine()!.Split().Select(x => (x)).ToArray();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = stroka[j];
        }
    }
}
void PrintArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}");
        Console.WriteLine();
    }
}
int Compare (string[,] arrayInput, string[,] arrayNegative)
{
    int count = 0;
    for (int i = 0; i < arrayInput.GetLength(0); i++)
    {
        for (int j = 0; j < arrayInput.GetLength(1); j++)
        {
            if (arrayInput[i,j] == arrayNegative[i,j])
            count++;
        }
    }
return count;
}
Console.Clear();
Console.Write("Введите кол-во строк исходника и негатива: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов исходника и негатива: ");
int M = int.Parse(Console.ReadLine()!);
string[,] arrayInput = new string[N, M];
string[,] arrayNegative = new string[N, M];
Console.WriteLine("Введите символы исходника построчно через пробел: ");
InputArray(arrayInput);
Console.WriteLine("Введите символы негатива построчно через пробел: ");
InputArray(arrayNegative);
Console.WriteLine("Исходник: ");
PrintArray(arrayInput);
Console.WriteLine("Негатив: ");
PrintArray(arrayNegative);
Console.WriteLine($"Количество ошибок: {Compare(arrayInput, arrayNegative)}");