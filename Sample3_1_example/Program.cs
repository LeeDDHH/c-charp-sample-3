// See https://aka.ms/new-console-template for more information

int num;

Console.Write("★の数を入力：");
try {
    num = int.Parse(Console.ReadLine());
} catch(Exception e) {
    Console.WriteLine($"ERROR:{e.Message}");
    return;
}

// for

for (int i = 0; i < num; i++) {
    Console.Write("★");
}
Console.WriteLine();

// while

int j = 0;
while (j < num) {
    Console.Write("★");
    j++;
}
Console.WriteLine();

// do while

if (num > 0) {
    int k = 0;
    do
    {
        Console.Write("★");
        k++;
    }
    while (k < num);
    Console.WriteLine();
}