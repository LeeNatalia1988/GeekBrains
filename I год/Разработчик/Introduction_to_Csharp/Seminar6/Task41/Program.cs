Console.Clear();
Console.WriteLine("Введите M (количество чисел): ");
int M = int.Parse(Console.ReadLine()!);
int[] array = new int[M];
Console.WriteLine("Введите числа: ");
for (int i = 0; i < array.Length; i++)
    array[i] = int.Parse(Console.ReadLine()!);
int count = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] > 0)
        count++;
Console.WriteLine($"Количество чисел больше 0: {count}");