//Задача 59: 
//Задайте двумерный массив целых чисел. Напишите программу, которая удалит строку и столбец,
//на пересечении которых находится наименьший элемент массива.


void NewArray(int[,] array, int index1min, int index2min)
{
    int[,] arr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i <= arr.GetLength(0); i++)
    {
        if (i == index1min) continue;
        for (int j = 0; j <= arr.GetLength(1); j++)
        {
            if (j == index2min) continue;
            arr[m, n] = array[i, j];
            n++;
        }
        m++;
        n = 0;
    }
    PrintMatrix(arr);
}


void FindMinDigitInArray(int[,] array)
{
    int min = array[0, 0];
    int index1min = 0;
    int index2min = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                index1min = i;
                index2min = j;
            }
        }
    }
    Console.WriteLine(index1min + ", " + index2min);
    Console.WriteLine("Минимальный элемент массива: " + min);
    NewArray(array, index1min, index2min);
}

//метод печати маcсива:
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

int leftRange = 10;
int rightRange = 100;
int rows = 5;
int columns = 6;

int[,] matrix = FillArrayWithRandomNumbers(rows, columns, leftRange, rightRange);
PrintMatrix(matrix);
System.Console.WriteLine();
FindMinDigitInArray(matrix);
//int[,] newmatrix = FindMinDigitInArray(matrix);
//PrintMatrix(newmatrix);