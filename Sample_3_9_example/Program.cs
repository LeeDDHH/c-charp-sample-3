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
Console.WriteLine();
Console.WriteLine("10ずつ増やし、範囲を決めてから表示する");

for (int i = 0; i <= 100; i += 10) {
    Console.Write($"{i}以上{i+10}未満： ");

    foreach (int n in rndIntArray) {
        if (n > i && n < i + 10) {
            Console.Write($"{n} ");
        }
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Dictionary使って、連想配列に範囲の最小値、最大値を設定してから表示する");

// Dictionary使って、連想配列に範囲の最小値、最大値を設定してから表示する

Dictionary<string, int>[] matrix = new Dictionary<string, int>[10];

int incrementSize = 10;
int sizeIndex = -1;

foreach (Dictionary<string, int> dic in  matrix) {
    sizeIndex++;
    matrix[sizeIndex] = new Dictionary<string, int >();
    matrix[sizeIndex].Add("min", sizeIndex * incrementSize);
    matrix[sizeIndex].Add("max", (sizeIndex + 1) * incrementSize);
}

foreach (Dictionary<string, int> dic in matrix)
{
    int min = dic["min"];
    int max = dic["max"];
    Console.Write($"{min}以上{max}未満： ");

    foreach (int n in rndIntArray)
    {
        if (n > min && n < max)
        {
            Console.Write($"{n} ");
        }
    }
    Console.WriteLine();
}