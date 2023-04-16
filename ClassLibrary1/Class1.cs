namespace ClassLibrary1
{
    public class Class1
    {
        public int[,] Method(int[,] array, int value)
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
}