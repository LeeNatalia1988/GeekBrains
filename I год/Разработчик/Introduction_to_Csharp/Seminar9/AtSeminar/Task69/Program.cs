int f(int a, int b)
{
  if (b == 0)
    return 1;
  return f(a, b - 1) * a;
}

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Результат: {f(a, b)}");
