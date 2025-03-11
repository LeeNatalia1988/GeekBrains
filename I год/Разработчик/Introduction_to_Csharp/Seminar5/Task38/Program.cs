void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * 10, 2);
}
double Maximum(double[] array)
{
    double Max = array[0];
    for (int i = 0; i < array.Length; i++)
    if (array[i] > Max)
        Max = array[i];
return Max;
}
double Minimum(double[] array)
{
    double Min = array[0];
    for (int i = 0; i < array.Length; i++)
    if (array[i] < Min)
        Min = array[i];
return Min;
}
Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(",  ", array)}]");
double Result = Maximum(array) - Minimum(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {Math.Round(Result,2)}");