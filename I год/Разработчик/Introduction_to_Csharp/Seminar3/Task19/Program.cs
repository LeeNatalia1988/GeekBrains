Console.Clear();
Console.Write("Введите пятизначное число: ");
string n = Convert.ToString(Console.ReadLine()!);
if (n.Length > 5)
{
    Console.WriteLine("Вы ввели не пятизначное число\nВведите число: ");
    n = Convert.ToString(Console.ReadLine()!);
}
else if (n[0] == n[4] && n[1] == n[3])
    Console.WriteLine("Число является полиндромом.");
    else
    Console.WriteLine("Число не является полиндромом.");
