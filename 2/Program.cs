// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
// суммой элементов: 1 строка

int[,] NewRandomArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}

int rows = new Random().Next(2, 6);
int columns = new Random().Next(2, 6);
Console.WriteLine("Массив:");

int[,] array = NewRandomArray(rows, columns);
int MinSumInRow (int[,] matrix)
{
    int minSum = 0;
    int minIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
        }
        Console.WriteLine ("Сумма элементов в строке " + i + ": " + sum);
        if (minSum > sum || i == 0)
        {
            minSum = sum;
            minIndex = i;
        }
    }
    return minIndex;
}
Console.WriteLine ("Номер строки с наименьшей суммой элементов: " + MinSumInRow(array));
