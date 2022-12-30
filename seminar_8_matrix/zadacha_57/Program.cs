//Задача 57: 
//Составить частотный словарь элементов двумерного массива.
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


void FindDigitInArray(int[,] array)
{
    for (int n = 0; n < 10; n++)
    {
        int variable = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == n) variable++;
            }
        }
        if(variable > 0) Console.WriteLine($"{n} встречается {variable} раз(а)");
    }
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

int leftRange = 0;
int rightRange = 10;
int rows = 4;
int columns = 3;

int[,] matrix = FillArrayWithRandomNumbers(rows, columns, leftRange, rightRange);
PrintMatrix(matrix);
System.Console.WriteLine();
FindDigitInArray(matrix);