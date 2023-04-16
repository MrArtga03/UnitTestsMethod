class Program
{
    static void Main(string[] args)
    {
        int[,] a = new int[,] { 
            { 1, 2, 3, 4, 5, 6, 7, 8 },
            { 1, 2, 3, 4, 5, 6, 7, 8 }
        };
        int value = 36;

        int[,] b = Method(a, value);

        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                Console.Write(b[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("--------------");


        int[,] a1 = new int[,] {
            { 1, 2, 3, 4, 5, 6, 7, 8 },
            { 1, 2, 3, 4, 5, 6, 7, 8 }
        };
        int value1 = 24;

        int[,] b1 = Method(a1, value1);

        for (int i = 0; i < b1.GetLength(0); i++)
        {
            for (int j = 0; j < b1.GetLength(1); j++)
            {
                Console.Write(b1[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static int[,] Method(int[,] array, int value)
    {
        int[,] result = new int[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
                sum += array[i, j];
            if (sum == value)
                result[i, 0] = value;
        }
        return result;
    }
}

