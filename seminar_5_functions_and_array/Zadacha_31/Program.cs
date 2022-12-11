//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов масссива.

//метод поиска сумм:
void SumPositiveAndNegative (int []arr, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumP += arr[i];//sumPositive = sumPositive + array[i]
        else
        {
            sumN += arr[i];
        }
    }    
}

//метод наполнения массива числами:
int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRang)//размер, левая граница, правая граница
{
    Random rand = new Random();
    int [] arr = new int[size];//обозначаем пока пустой массив
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRang + 1);
    }
    return arr;
}

//Программа:
const int SIZE = 7;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;

int [] array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');
SumPositiveAndNegative (array, out int sumP, out int sumN);

Console.WriteLine($"Сумма + элементов: {sumP}");
Console.WriteLine($"Сумма - элементов: {sumN}");
