string f(int n, int m)
{
    if (m >= n)
        return $"{m} ";
    return $"{m} " + f(n, m + 1);
}


Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(n, m));
