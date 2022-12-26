//Задача 55: 
//Задайте двумерный массив. Напишите программу, которая заменит строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.


//Замена строк на столбцы в массиве:
int[,] ReplacingRowsOnColumnsInMatrix(int[,] array)
{
    //int variable = array[0, 0];
    int[,] newarray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newarray[i, j] = array[j, i];
        }
    }
    return newarray;
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
int[,] FillArrayWithRandomNumbers(int rows, int columns, int leftRange, int rightRang)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRang + 1);
        }
    }
    return array;
}

//Прием чисел от пользователя:

int DataEntyNumber(string message)
{
    System.Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//программа:

const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 9;
int rows = DataEntyNumber("Введите число строк m:");
int columns = DataEntyNumber("Введите число столбцов n: ");

int[,] matrix = FillArrayWithRandomNumbers(rows, columns, LEFT_RANGE, RIGHT_RANGE);

PrintMatrix(matrix);
Console.WriteLine();

if (rows == columns)
{
    int[,] newmatrix = ReplacingRowsOnColumnsInMatrix(matrix);
    PrintMatrix(newmatrix);
}
else
{
    Console.WriteLine("Замена строк на столбцы невозможна");
}