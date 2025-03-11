Console.Clear();
Console.WriteLine("Введите число: ");
string N = Convert.ToString(Console.ReadLine()!);
int Summ = 0;
for (int i = 0; i < N.Length; i++)
{
    Summ = Summ + Convert.ToInt32(N[i].ToString());
}
Console.WriteLine($"Сумма цифр заданного числа: {Summ}.");
