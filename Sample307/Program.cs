// See https://aka.ms/new-console-template for more information

int[] n = { 5, 4, 3, 2, 1 };
string[] s = { "ABC", "DEF", "GHI" };

int i = 0;

for (i = 0; i < n.Length; i++) {
    Console.Write($"{n[i]} ");
}

Console.WriteLine();

for (i = 0; i < s.Length; i++)
{
    Console.Write($"{s[i]} ");
}