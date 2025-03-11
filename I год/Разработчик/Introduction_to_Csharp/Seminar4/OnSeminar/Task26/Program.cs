Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int n = 0;
do
{
    a = a/10;
    n++;
}
while (a > 0);
Console.WriteLine($"Количество цифр в заданном числе: {n}");