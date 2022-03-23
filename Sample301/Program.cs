// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int[] intArray = new int[] { 1, 2, 3, 4, 5 };

// 基本的なfor

for (int i = 1; i <= 5; i++) {
    Console.Write(i + " ");
}
Console.WriteLine();

// 基本的なforeach

foreach (int num in intArray) {
    Console.Write(num + " ");
}

Console.WriteLine();
Console.WriteLine();

// 多重ループ

for (int i = 1; i <= 2; i++) {
    for (int j = 1; j <= 3; j++) {
        int k = i + j;
        Console.WriteLine("{0} + {1} = {2}", i, j, k);
    }
    Console.WriteLine();
}