//Задача 50. Напишите программу, которая на вход принимает значение этого элемента в двумерном массиве, 
//и возвращает позицию этого элемента или же указание, что такого элемента нет.

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}


void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}


int m = EnterNumber("Insert m:  ");
int n = EnterNumber("Insert n:  ");
int[,] matrix = CreateRandomArray(m, n, 1, 10);
PrintArr(matrix);
Console.WriteLine();
int Element = EnterNumber("insert N : ");
int i=0; 
int j=0;
if (Element == matrix[i, j])
                {
                    Console.WriteLine($"{Element} => {i},{j}");
                }
                else Console.WriteLine($"{Element} => element not found in array  ");

