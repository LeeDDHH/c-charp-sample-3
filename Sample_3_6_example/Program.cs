// See https://aka.ms/new-console-template for more information

int[] a = new int[5];

// 数値入力
for (int i = 0; i < a.Length; i++) {
    Console.WriteLine($"{i+1}番目の数値：");
    int n = int.Parse(Console.ReadLine());
    a[i] = n;
}

Console.WriteLine("入力された数値の一覧");

// 数値表示
for (int i = 0; i < a.Length; i++) {
    Console.Write($"{i} ");
}

Console.WriteLine();

// 最大値、最小値
int max = a[0];
int min = a[0];
for (int i = 0; i < a.Length; i++)
{
    if (a[i] > max) {
        max = a[i];
    }
    if (a[i] < min) {
        min = a[i];
    }
}

Console.WriteLine($"最大値：{max}");
Console.WriteLine($"最小値：{min}");