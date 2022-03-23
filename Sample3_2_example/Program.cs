// See https://aka.ms/new-console-template for more information

Console.Write("正の整数を入力：");
int num;
try {
    num = int.Parse(Console.ReadLine());
} catch (Exception e) {
    Console.WriteLine($"Exception: {e.Message}");
    return;
}

// for

for (int i = 1; i <= num; i++) {
    if (num % i == 0) {
        Console.Write($"{i} ");
    }
}
Console.WriteLine();

// while

int j = 1;
while (j <= num) {
    if (num % j == 0) {
        Console.Write($"{j} ");
    }
    j++;
}
Console.WriteLine();

// do while

int k = 1;

if (num > 0) {
    do
    {
        if (num % k == 0)
        {
            Console.Write($"{k} ");
        }
        k++;
    } while (k <= num);
}
Console.WriteLine();