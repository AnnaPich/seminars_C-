//Задача 35: 
//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5


//метод поиска чисел:
int FindNumber(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>=10 && arr[i]<=99) count++; 
    }
return count;
}

//метод заполнения массива:
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

const int SIZE = 123;
const int LEFT_RANGE = -999;
const int RIGHT_RANGE = 999;

int [] array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.Write('[' + string.Join(", ", array) + ']');
int count = FindNumber(array);

Console.WriteLine($"-> {count}");