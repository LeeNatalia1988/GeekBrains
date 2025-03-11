Console.Clear();
Console.WriteLine("Введите количество цифр: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число K: ");
int K = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] array1 = new int[n];
int j = 0;
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(0, 101);
}
Console.WriteLine($"Изначальный массив: [{string.Join(", ", array)}]");
if (K > 0)
{
    for (j = 0; j < array.Length; j++)
    {
        if (j + K <= array.Length - 1)
        array1[K + j] = array[j];
        else 
        array1[(K + j) - array.Length] = array[j];
    }
}
else
{
    for (j = 0; j < array.Length; j++)
    {
        if (j + K >= 0)
        array1[K + j] = array[j];
        else 
        array1[(K + j) + array.Length] = array[j];
    }
}    
Console.WriteLine($"Массив после сдвига: [{string.Join(", ", array1)}]");