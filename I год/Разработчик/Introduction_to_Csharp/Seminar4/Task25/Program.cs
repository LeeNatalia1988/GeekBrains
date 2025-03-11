Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
double Result = 1;
if (b == 0)
    Result = 1;
if (b < 0)
{
    for (int i = 1; i <= Math.Abs(b); i++)
    {
        Result = Result * a;
    }
    Result = 1/Result;
}
else
{
    for (int i = 1; i <= b; i++)
    {
    Result = Result * a;
    }
}
Console.WriteLine($"Результат возведения первого числа в степень, равную второму числу: {Math.Round(Result, 2)}");
