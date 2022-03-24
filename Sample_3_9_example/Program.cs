Random rnd = new Random();

int[] rndIntArray = new int[10];
int index = -1;

foreach (int i in rndIntArray)
{
    index++;
    rndIntArray[index] = rnd.Next(1, 100);
    Console.Write($"{rndIntArray[index]} ");
}

Console.WriteLine();

for (int i = 0; i <= 100; i += 10) {
    Console.Write($"{i}以上{i+10}未満： ");

    foreach (int n in rndIntArray) {
        if (n > i && n < i + 10) {
            Console.Write($"{n} ");
        }
    }
    Console.WriteLine();
}