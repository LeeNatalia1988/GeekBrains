Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());
if (a == 6 || a == 7)
{
    Console.WriteLine("Вихатной!");
}
else
{
    Console.WriteLine("Не вихатной!");
}
