//Задача 32: 
//Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        array[i] = array[i] * -1;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int[] arr = { -4, -8, 8 ,2};

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);