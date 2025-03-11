int f(int n)
{
  if (n / 10 == 0 || n < 10 || n % 10 == n)
    return n;
  return f(n / 10) + n % 10;
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Результат: {f(n)}");
