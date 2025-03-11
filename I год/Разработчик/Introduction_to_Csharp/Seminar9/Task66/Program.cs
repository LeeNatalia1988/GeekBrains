//OK
int Summ(int m, int n, int Sum)
{
    Sum = Sum + m;
    if (m >= n)
        return Sum;
    return Summ(m + 1, n, Sum);
}
Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
int Sum = 0;
Console.WriteLine("Сумма натуральных чисел от M до N: ");
Console.WriteLine(Summ(m, n, Sum));
