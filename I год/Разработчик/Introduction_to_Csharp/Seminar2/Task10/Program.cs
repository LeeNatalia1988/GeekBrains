Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
a = (a/10)%10;
Console.WriteLine($"Вторая цифра данного числа: {a}.");