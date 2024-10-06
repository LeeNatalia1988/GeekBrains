Console.Clear();
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
for (int i = 2; i <= N; i+=2)
    if (i%2==0)
    Console.Write($"{i}  "!);
