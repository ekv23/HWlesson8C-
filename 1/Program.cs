// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//1 2 4 7
//2 3 5 9
//2 4 4 8

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
int[,] IncreasingRows(int[,] matrix)
{
    int minPosition,
        temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            minPosition = j;
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] < matrix[i, minPosition]) minPosition = k;
            }
            temp = matrix[i, j];
            matrix[i, j] = matrix[i, minPosition];
            matrix[i, minPosition] = temp;
        }
    }
    return matrix;
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " ");
        Console.WriteLine();
    }
}
int rows = new Random().Next(2, 6);
int columns = new Random().Next(2, 6);
Console.WriteLine("Первоначальный массив:");
int[,] array = NewRandomArray(rows, columns);

Console.WriteLine("Упорядоченный массив:");
PrintArray(IncreasingRows(array));