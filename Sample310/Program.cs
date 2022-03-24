// See https://aka.ms/new-console-template for more information

int[][] a = new int[][] {
    new int[] { 0, 1 },
    new int[] { 2 },
    new int[] { 3, 4, 5, 6 }
};

for (int m = 0; m < a.Length; m++) {
    for (int n = 0; n < a[m].Length; n++) {
        Console.Write($"{m}番目の配列の中の{n}番目の要素：{a[m][n]} ");
    }
    Console.WriteLine();
}