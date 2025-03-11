Console.Clear();
Console.WriteLine("Введите первое число: ");
double A = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
double B = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
double C = double.Parse(Console.ReadLine()!);
if (A + B > C && B + C > A && C + A > B)
    Console.WriteLine("Да.");
else 
Console.WriteLine("Нет.");
