//Задача 26:
//Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

int QuantityDigit (int number)
{
    int i = 1;
    for (i = 1; number > 10; i++)
    {
        number = number/10;
    }
    return i;
}


int DataEntryNumber (string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}   

//Программа:

Console.Clear();

int number = DataEntryNumber("Введите число: ");
int result = QuantityDigit(number); // Обращение к методу, считающему цифры
Console.Write(number +"-> " + result);