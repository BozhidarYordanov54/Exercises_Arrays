int[] arr = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int rotations = int.Parse(Console.ReadLine());

for(int i = 0; i < rotations; i++)
{
    int firstElement = arr[0];

    for(int j = 0; j < arr.Length - 1; j++)
    {
        arr[j] = arr[j + 1];

        if(j == arr.Length - 2)
        {
            arr[j + 1] = firstElement;
        }
    }
}

Console.WriteLine(string.Join(" ", arr));