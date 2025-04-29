namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{ 0, 1, 2, 3, 12, 13, 2, 1 };
            PrintResult(SortImper(arr));
            Console.WriteLine("===============");
            PrintResult(SortDecl(arr));
        }

        // Использую обычный двойной перебор со сравнением элементов между собой
        static int[] SortImper(int[] arr)
        {
            if (arr.Length < 2)
            {
                return arr;
            }
            else
            {
                int temp = 0;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            return arr;
        }

        // Использую методы sort и reverse
        static int[] SortDecl(int[] arr)
        {
            if (arr.Length < 2) 
            {
                return arr;
            }
            else
            {
                Array.Sort(arr);
                Array.Reverse(arr);
                return arr;
            }
        }

        
        static void PrintResult(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]}, ");
            }
        }
    }
}
