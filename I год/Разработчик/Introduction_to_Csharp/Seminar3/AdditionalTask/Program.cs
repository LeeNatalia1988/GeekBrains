Console.Clear();
int[] numbers = new int[] {4,1,5,4};
int max = 0;
if (numbers.Length == 3)
{
    max = numbers[0] + numbers[1] + numbers[2];
}
else
{
    for (int i = 1; (i < numbers.Length - 2); i++)
        {
        if ((numbers[i-1] + numbers[i] + numbers[i+1]) < (numbers[i] + numbers[i+1] + numbers[i+2]))
        max = numbers[i] + numbers[i+1] + numbers[i+2];
        }
}
if ((numbers[numbers.Length - 2] + numbers[numbers.Length - 1] + numbers[0]) > max)
    max = numbers[numbers.Length - 2] + numbers[numbers.Length - 1] + numbers[0];
if ((numbers[numbers.Length - 1] + numbers[0] + numbers[1] > max))
    max = numbers[numbers.Length - 1] + numbers[0] + numbers[1];
Console.WriteLine($"Максимальное количество собранных ягод за один заход собирающим модулем: {max}.");