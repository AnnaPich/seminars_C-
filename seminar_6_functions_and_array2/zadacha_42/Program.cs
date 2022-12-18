//Задача 42: 
//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10


int QuantityDigitInNumber (int numb)
{
    int count = 0;
    for (int i = 0; numb > 0; i++)
    {
        numb /= 2;
        count = i + 1;
    }
    return count;
}

int DataEntryNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}



//Программа:

int number = DataEntryNumber("введите число: ");

int digit = QuantityDigitInNumber(number);

int size = digit;
int count = number;
int [] arr = new int[size];
for (int i = 0; i < size; i++)
{
    arr [size -1 - i] = count % 2;
    count /= 2;
}
Console.Write(string.Join(", ", arr));