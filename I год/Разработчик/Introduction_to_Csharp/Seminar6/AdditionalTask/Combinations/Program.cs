void InputArray(string[] array, string[] array1)
{
    for (int i = 0; i < array.Length; i++)
        array1[i] = array[i];
}
void NextCombinations(string[] array, string[] Combinations, string[] array1, string[] Combinations1, int k)
{
    int m = 0;
    while (m != Combinations.Length)
    {
        PrintArray(Combinations);
        for (int i = 0; i < Combinations.Length; i++)
        {
            if (i + k < Combinations.Length)
                Combinations[k + i] = array1[i];
            else
                Combinations[k + i - array1.Length] = array1[i];
        }
        for (int i = 0; i < Combinations.Length; i++)
            array1[i] = Combinations[i];
        for (int i = 0; i < Combinations.Length; i++)
            if (Combinations[i] == Combinations1[i])
                m++;
    }
    int n = 0;
    for (int i = 0; i < Combinations.Length; i++)
        if (Combinations[i] == Combinations1[i])
            n++;
    if (array.Length > 2 && n == Combinations.Length)
    {
        Combinations[1] = array1[2];
        Combinations[2] = array1[1];
        for (int i = 0; i < Combinations.Length; i++)
            array1[i] = Combinations[i];
    }
    m = 0;
    for (int i = 0; i < Combinations.Length; i++)
        Combinations1[i] = Combinations[i];
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        Console.Write($"{array[i]}\t");
    Console.WriteLine();
    Console.WriteLine();
}
Console.Clear();
Console.Write("Введите кол-во символов: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите символы построчно через пробел: ");
string[] array = Console.ReadLine()!.Split().Select(x => (x)).ToArray();
string[] Combinations = FirstCombinations(array, N);
string[] array1 = FirstCombinations(array, N);
string[] Combinations1 = FirstCombinations(array, N);
Console.WriteLine("Комбинации из заданных символов: ");
int k = array.Length - 1;
for (int i = 0; i < array.Length - 1; i++)
    NextCombinations(array, Combinations, array1, Combinations1, k - i);






