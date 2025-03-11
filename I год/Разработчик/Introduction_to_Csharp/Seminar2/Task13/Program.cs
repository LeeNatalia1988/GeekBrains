Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(a);
if (a/100 == 0)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{    
    Console.WriteLine("Третья цифра этого числа: " +stringNumber[2]);
}    
