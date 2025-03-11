double Triangle(double[] array)
{
    double Result = 0;
    Result = Math.Abs((array[2] - array[0])*(array[5] - array[1]) - (array[4] - array[0])*(array[3] - array[1]))/2;
    return Math.Round(Result, 2);
}
Console.Clear();
Console.WriteLine("Введите координаты вершин треугольника (x1, y1, x2, y2, x3, y3) через пробел: ");
double[] array = Console.ReadLine()!.Split().Select(x => double.Parse(x)).ToArray();
Console.WriteLine($"Площадь треугольника: {Triangle(array)}");

