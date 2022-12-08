//Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

int ResultProduct (int number)
{
    int product = 1;
    for (int i = 1; i <= number; i++)
    {
        product = product * i;
    }
    return product;
}


int DataEntryN (string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}   

//Программа:

Console.Clear();

int digitN = DataEntryN ("Введите число N: ");
int result = ResultProduct(digitN); 
Console.Write(digitN +"-> " + result);