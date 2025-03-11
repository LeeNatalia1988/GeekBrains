void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = i + 4;
//Console.WriteLine($"Массив всех чисел: [{string.Join(", ", array)}]");
}
void SimpleNumbers (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 2; j < array[i]; j++)
        {
            if (array[i]%j == 0)
            {
                array[i] = 0;
                break;
            }
        }
    }
//Console.WriteLine($"Массив простых чисел: [{string.Join(", ", array)}]");
}
void Summa(int[] array, int N)
{
    int Summ = 1000;
    int A = 1;
    int B = 1;
    for (int i = 0; i < array.Length; i++)
    { 
        for (int j = 0; j < array.Length; j++)
        { 
        if ((Summ > (array[i] + array[j])) && (array[i] + array[j]) == N)
        {
            Summ = array[i] + array[j];
            A = array[i];
            B = array[j];
        }
        }
    }
if (A == 1 && B ==1)
Console.WriteLine("Для данной последовательности таких чисел нет (ПС: введите 8 и более).");
else
Console.WriteLine($"Первое простое число: {A}\nВторое простое число: {B}");
}
Console.Clear();
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N<4 || N>998 || N%2 != 0)
    {
        Console.WriteLine("Вы ввели неверное число согласно условию. \nВведите верное число (четное число, которое не менее 4 и не более 998): ");
        N = Convert.ToInt32(Console.ReadLine());
    }
int[] array = new int[N-3];
InputArray(array);
SimpleNumbers(array);
Summa(array, N);
