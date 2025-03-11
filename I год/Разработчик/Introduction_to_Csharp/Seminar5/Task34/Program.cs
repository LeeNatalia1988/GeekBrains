void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 1001);
}
void NumberOfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i]%2 == 0)
        count++;
    Console.WriteLine($"Количество четных элементов данного массива: {count}");
}
Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
NumberOfEven(array);

