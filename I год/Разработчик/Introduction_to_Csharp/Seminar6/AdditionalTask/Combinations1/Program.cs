string Combinations(string[] array, int k)
{
    string[] Temp = new string[array.Length - 1];
    string[] A = new string[1];
    A[0] = array[k];
    array[k] = array[0];
    array[0] = A[0];
    for (int i = 0; i < Temp.Length; i++)
        Temp[i] = array[i + 1];
    int j = 0;
    while (j < Temp.Length)
    {
        for (int i = 0; i < Temp.Length - 1; i++)
        {
            if (i + 1 < Temp.Length)
            {
                A[0] = Temp[i + 1];
                Temp[i + 1] = Temp[i];
                Temp[i] = A[0];
            }
            else
            {
                A[0] = Temp[i + 1 - Temp.Length];
                Temp[i + 1 - Temp.Length] = Temp[i];
                Temp[i] = A[0];
            }
        }
        Console.WriteLine($"{array[0]} {string.Join(" ", Temp)}");
        j++;
    }
    if (k >= array.Length - 1)
        return $"{array[0]} {string.Join(" ", Temp)}";
    else return Combinations(array, k + 1);
}
Console.Clear();
Console.WriteLine("Введите символы построчно через пробел: ");
string[] array = Console.ReadLine()!.Split().Select(x => (x)).ToArray();
Console.WriteLine("Заданные символы: ");
Console.WriteLine($"{string.Join(" ", array)}");
Console.WriteLine("Комбинации: ");
int k = 0;
Combinations(array, k);
