// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

System.Console.WriteLine("Введите число N:   ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);

int[] GetSqrtTable(int N)
{
    int[] SqrtArray = new int[N];
    int number = 1;
    for (int i = 0; i < N; i++)
    {
        SqrtArray[i] = number * number;
        number++;
    }
    return SqrtArray;
}

void PrintTable(int[] Array)
{
    int number = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write($"{number} ^ 2 = ");
        System.Console.WriteLine(Array[i]);
        number++;
    }
}

int[] SqrtTable = GetSqrtTable(N);
PrintTable(SqrtTable);