void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
}
void Count(int[] array)
{
    int CountEven = 0;
    int CountOdd = 0;
    Console.WriteLine("Тройки получил: ");
    for (int i = 0; i < array.Length; i++)
    if (array[i]%2 != 0)
    {
        Console.Write($"{array[i]}, ");
        CountOdd++;
    }
    Console.WriteLine();
    Console.WriteLine("Четверки получил: ");
    for (int i = 0; i < array.Length; i++)
    if (array[i]%2 == 0)
    {
        Console.Write($"{array[i]}, ");
        CountEven++;
    }
    Console.WriteLine();
    if (CountEven > CountOdd)
    Console.WriteLine("YES!");
    else
    Console.WriteLine("NO!");
}
Console.Clear();
Console.WriteLine("Введите количество дней: ");
int N = Convert.ToInt32(Console.ReadLine()!);
int[] array = new int[N];
InputArray(array);
Count(array);