// See https://aka.ms/new-console-template for more information

Random rnd = new Random();

int[] rndIntArray = new int[10];
int index = -1;

foreach (int i in rndIntArray) {
    index++;
    rndIntArray[index] = rnd.Next(1,101);
    Console.Write($"{rndIntArray[index]} ");
}

Console.WriteLine();

Array.Sort(rndIntArray);

foreach (int i in rndIntArray)
{
    Console.Write($"{i} ");
}