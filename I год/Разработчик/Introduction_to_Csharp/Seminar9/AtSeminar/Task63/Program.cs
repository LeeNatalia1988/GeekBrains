﻿string f(int n)
{
    if (n == 1)
        return "1 ";
    return f(n - 1) + $"{n} ";
}


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(n));

// В обратном порядке
string f(int n)
{
    if (n == 1)
        return "1";
    return  $"{n} " + f(n - 1);
}


Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(n));
