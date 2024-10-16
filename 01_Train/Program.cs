int numOfLines = int.Parse(Console.ReadLine());

int[] peopleInTrainWagons = new int[numOfLines];

for(int i = 0; i < numOfLines; i++)
{
    int input = int.Parse(Console.ReadLine());

    peopleInTrainWagons[i] = input;
}


Console.WriteLine($"{string.Join(" ", peopleInTrainWagons)}");
Console.WriteLine(peopleInTrainWagons.Sum());