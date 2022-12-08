//Задача 30:
//Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(col[i] + ", ");
    }
}

int [] NewArray(int [] array)
{
    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(2);
    }
    return array;
    //Console.Write (array);
}

//Программа:

int [] array = new int [8];
NewArray(array);
Console.Write("Массив: [");
PrintArray(array);
Console.Write("]");
