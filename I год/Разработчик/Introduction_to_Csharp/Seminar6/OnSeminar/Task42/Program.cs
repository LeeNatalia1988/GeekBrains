Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int result = 0, count = 1;
while (n > 0)
{
    result += (n % 2) * count;
    n /= 2;
    count *= 10;
}
Console.WriteLine(result);

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// string result = string.Empty;
// while (n > 0)
// {
//     result = Convert.ToString(n % 2) + result;
//     n /= 2;
// }
// Console.WriteLine(result);
    

