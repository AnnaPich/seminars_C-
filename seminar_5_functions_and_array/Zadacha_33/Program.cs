//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да
Console.Clear();

//метод поиска заданного числа в массиве:
void FindNumber(int [] arr, int number, out int count)
{
    count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr [i] == number) count = 1;
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

//метод приема числа от пользователя:
int DataEntryNumber (string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Программа:
int number = DataEntryNumber("Введите число: ");

const int SIZE = 7;
const int LEFT_RANGE = -5;
const int RIGHT_RANGE = 9;

int [] array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine('[' + string.Join(", ", array) + ']');
FindNumber(array, number, out int count);

if(count == 1) Console.WriteLine($"число {number} есть в массиве");
else Console.WriteLine($"числа {number} в массиве нет");

  