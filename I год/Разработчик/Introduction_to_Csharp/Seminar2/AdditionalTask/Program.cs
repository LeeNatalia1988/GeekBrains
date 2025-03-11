Console.Clear();
int[] numbers = new int[] {1,2,,3,4,5,0};
int max1 = numbers[0];
int max2 = numbers[1];
if (max2 > max1)
{
      max1 = max2;
      max2 = numbers[0];
}
for (int i = 0; i < numbers.Length; i++)
{
     if (numbers[i] == 0) break;
     if (max1 < numbers[i])
     {
      max1 = numbers[i];
     }
}
for (int i = 0; i < numbers.Length; i++)
{
      if (numbers[i] > max2 && numbers[i] < max1)
      max2 = numbers[i];
}
Console.WriteLine($"Второе максимальное число: {max2}.");





