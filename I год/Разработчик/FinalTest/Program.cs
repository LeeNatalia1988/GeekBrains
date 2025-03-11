void PrintMatrix(string[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
        if (matrix[i] != string.Empty)
            Console.Write($"{matrix[i]}\t");
}
Console.Clear();
Console.WriteLine("Введите строки через пробел:");
string[] matrix = Console.ReadLine()!.Split().Select(x => (x)).ToArray();
string[] matrix1 = new string[matrix.Length];
Console.WriteLine();
Console.WriteLine("Исходный массив из введенных строк:");
PrintMatrix(matrix);
Console.WriteLine();
for (int i = 0; i < matrix.Length; i++)
{
    if (matrix[i].Length > 3)
        matrix1[i] = string.Empty;
    else
        matrix1[i] = matrix[i];
}
Console.WriteLine();
Console.WriteLine("Массив из строк, длина которых не превышает трех символов:");
PrintMatrix(matrix1);


