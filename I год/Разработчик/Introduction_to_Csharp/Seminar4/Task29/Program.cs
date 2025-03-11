Console.Clear();
int n = 8;
Console.WriteLine("Задданый массив из 8-ми элементов: ");
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(-100, 1001);
    Console.Write($"{array[i]}, ");
}

