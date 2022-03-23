// See https://aka.ms/new-console-template for more information

// 乱数の初期設定
Random rnd = new Random();
Console.WriteLine("6が出たら終了");

// 無限ループ
while (true) {
    // 1以上7未満の乱数を発生させる
    int dice = rnd.Next(1, 7);
    Console.WriteLine(dice);
    if (dice == 6) {
        break;  // ループから抜ける
    }
}
Console.WriteLine("終了");