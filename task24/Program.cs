// Написать программу для разворота массива

Console.Write("Введите количество элементов массива:\t");

int elementsCount = int.Parse(Console.ReadLine());

int[] myArray = new int[elementsCount];

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"\nВведите элемент массива под индексом {i}:\t ");
    myArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nВывод массива:");

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}

Console.WriteLine("\nВывод массива в обратном порядке:");

for (int i = myArray.Length - 1; i >= 0; i--)
{
    Console.WriteLine(myArray[i]);
}