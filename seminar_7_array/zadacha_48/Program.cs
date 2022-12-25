//Задача 48: 
//Задайте двумерный массив размером mXn, заполненный случайными целыми числами.
//Каждый элемент в массиве находтся по формуле: А[i,j] = i + j.
//m = 3; n = 4
//0 1 2 3
//1 2 3 4 
//2 3 4 5
//
Console.Clear();


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
int[,] FillArrayNumbers(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
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

int rows = DataEntyNumber("Введите число строк m:");
int columns = DataEntyNumber("Введите число столбцов n: ");

int[,] matrix = FillArrayNumbers(rows, columns);

PrintMatrix(matrix);

