//Задача 53: 
//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строки массива.

//метод замены строк:
int[,] ReplacingStringsInMatrix(int[,] array)
{
    int variable = array[0, 0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        variable = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = variable;
    }
    return array;
}

//метод печати масива:
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//метод заполнения массива:
int[,] FillArrayWithRandomNumbers(int rows, int columns, int leftRange, int rightRange)
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

//программа:


int leftRange = 0;
int rightRange = 10;
int rows = 4;
int columns = 3;

int[,] matrix = FillArrayWithRandomNumbers(rows, columns, leftRange, rightRange);
PrintMatrix(matrix);
System.Console.WriteLine();

int[,] newmatrix = ReplacingStringsInMatrix(matrix);
PrintMatrix(newmatrix);