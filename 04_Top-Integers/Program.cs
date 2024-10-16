class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int maxRight = int.MinValue;

        int[] result = new int[arr.Length];
        int resultCounter = 0;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] > maxRight)
            {
                maxRight = arr[i];

                result[resultCounter] = maxRight;
                resultCounter++;
            }
        }

        for (int i = resultCounter - 1; i >= 0; i--)
        {
            Console.Write(result[i] + " ");
        }
    }
}
