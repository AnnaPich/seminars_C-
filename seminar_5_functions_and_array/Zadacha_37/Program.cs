//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

//метод поиска произведений чисел:
void FindMultNumbers(int [] arr, int size)
{
    for (int i = 0; i < size/2; i++)
    {
        int digit = arr[i] * arr[size-1-i];
        Console.Write($"{digit}, ");
    }
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

const int SIZE = 6;
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 9;

int [] array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.Write('[' + string.Join(", ", array) + ']');
Console.Write("-> ");
FindMultNumbers(array, SIZE);