//Задача 51: 
//Задайте двумерный массив. Найдите сумму элементов главной диаганали (у которых индекс i равен индексу j).
Console.Clear();

//метод поиска суммы элементов главной диаганали:

void PrintSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) sum += array[i, j];
        }
    }
    Console.WriteLine("Сумма элементов главной диаганали равна: " + sum);
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

    PrintSum(matrix);
