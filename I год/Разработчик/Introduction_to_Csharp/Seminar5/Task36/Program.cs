void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 1001);
}
void Summ(int[] array)
{
    int Summ = 0;
    for (int i = 1; i < array.Length; i+=2)
        Summ = Summ + array[i];
    Console.WriteLine($"Сумма элементов данного массива, стоящих на нечетных позициях: {Summ}");
}
Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Summ(array);
