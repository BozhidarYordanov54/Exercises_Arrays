int arrSize = int.Parse(Console.ReadLine());

int[] arrOdd = new int[arrSize];
int[] arrEven = new int[arrSize];

for(int i = 0; i < arrSize; i++)
{
    int[] input = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    if(i % 2 == 0)
    {
        arrEven[i] = input[0];
        arrOdd[i] = input[1];
    }
    else
    {
        arrEven[i] = input[1];
        arrOdd[i] = input[0];
    }
}

Console.WriteLine(string.Join(" ", arrEven));
Console.WriteLine(string.Join(" ", arrOdd));