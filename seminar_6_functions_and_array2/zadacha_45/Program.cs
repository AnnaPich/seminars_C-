//Задача 45: 
//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


Console.Clear();

//метод копирования массива:

void CopyArray(int []arr, int size)
{
    int [] arrCopy = new int [size];
    for (int i = 0; i < arrCopy.Length; i++)
    {
        arrCopy[i] = arr[i];
    }
    Console.WriteLine('[' + string.Join(", ", arrCopy) + ']');
}


//метод заполнения массива:
int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRang)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRang + 1);
    }
    return arr;
}

//Программа:

const int SIZE = 7;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

int[] array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');
CopyArray(array, SIZE);

//Вариант 2: копирование ссылкой: 
int [] secondArray = array;
Console.WriteLine('[' + string.Join(", ", secondArray) + ']');