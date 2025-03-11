Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
for (int i = 1; i <= Math.Abs(n); i++)
a = a * i;
Console.WriteLine($"Произведение чисел: {a}");
