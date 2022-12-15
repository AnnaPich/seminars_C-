//Напишите программу, которая перевернет одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

Console.Clear();

//Метод переворота массива:
void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
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
Console.Write('[' + string.Join(", ", array) + ']');
ReverseArray(array);
Console.Write('[' + string.Join(", ", array) + ']');