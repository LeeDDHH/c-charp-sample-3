// See https://aka.ms/new-console-template for more information

int[] n = { 1, 2, 3, 4 };

// 基本型

Console.WriteLine("基本型");

foreach (int i in n) {
    Console.Write($"{i} ");
}

Console.WriteLine();

// 値とインデックスを取得する方法
// C# 7.0以降で使えるタプル(tuple)を使った方法

Console.WriteLine("タプル(tuple)を使った方法");

foreach (var (value, index) in n.Select((value, index) => (value, index)))
{
    Console.WriteLine($"index={index} value={value}");
}

Console.WriteLine();

// 匿名型を使った方法

Console.WriteLine("匿名型を使った方法");

foreach (var item in n.Select((value, index) => new { value, index }))
{
    Console.WriteLine($"index={item.index} value={item.value}");
}

Console.WriteLine();

// index用の変数を使った方法

Console.WriteLine("index用の変数を使った方法");

int indexForArray = -1;

foreach (var value in n) {

    // continue を考慮し、必ずループの先頭でインクリメント
    indexForArray += 1;
    Console.WriteLine($"index={indexForArray} value={value}");
}
