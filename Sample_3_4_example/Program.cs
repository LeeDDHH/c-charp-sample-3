// See https://aka.ms/new-console-template for more information

Random rnd = new Random();

int max = 0;
int min = 101;
int count = 1;

Console.WriteLine("1から100の間の数をランダムに10回生成する");
Console.WriteLine("最大値と最小値を表示する");

while(count <= 10)
{
    int rndValue = rnd.Next(1, 101);
    Console.Write($"{rndValue} ");

    if (rndValue > max) {
        max = rndValue;
    }
    if (rndValue < min) {
        min = rndValue;
    }
    count++;
};

if (count >= 10) {
    Console.WriteLine();

    Console.WriteLine($"最大値：{max}");
    Console.WriteLine($"最小値：{min}");
};