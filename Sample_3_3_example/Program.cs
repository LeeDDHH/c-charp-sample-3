// See https://aka.ms/new-console-template for more information

Console.WriteLine("数あてゲーム");
Console.WriteLine("0から10の数値を入力してください。");
int count = 1;
Random rnd = new Random();
int rndNum = rnd.Next(0, 11);
while(count <=3)
{
    Console.Write($"{count}回目：");
    int answer = int.Parse(Console.ReadLine());
    if (answer > rndNum)
    {
        Console.WriteLine("大きすぎます。");
    }
    else if (answer < rndNum)
    {
        Console.WriteLine("小さすぎます。");
    }
    else
    {
        Console.WriteLine("正解です！");
        break;
    }
    count++;
};

if (count > 3)
{
    Console.WriteLine("ゲームオーバー！");
    Console.WriteLine($"正解は{rndNum}です。");
}