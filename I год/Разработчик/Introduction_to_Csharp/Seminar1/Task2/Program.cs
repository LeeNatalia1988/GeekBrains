Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (a==b)
Console.WriteLine("Числа равны.");
else if (a<b)
Console.WriteLine($"Большее число: {b}, Меньшее число: {a}");

    else
        Console.WriteLine($"Большее число: {a}, Меньшее число: {b}");
