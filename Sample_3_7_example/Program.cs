// See https://aka.ms/new-console-template for more information

Random rnd = new Random();

int[] intArray = new int[10];

for (int i = 0; i < 10; i++) {
    int rndNum = rnd.Next(1, 101);
    intArray[i] = rndNum;
    Console.Write($"{rndNum} ");
};

Console.WriteLine();

string[] names = { "偶数:", "奇数:" };

for (int i = 0; i <= 1; i++) {
    Console.Write(names[i]);

    for (int j = 0; j < intArray.Length; j++) {
        if (intArray[j] % 2 == i) {
            Console.Write($"{intArray[j]} ");
        }
    }
    Console.WriteLine();
}