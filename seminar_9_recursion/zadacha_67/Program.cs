//Задача 67:
//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12



void SumDigitInNumber(int number, int sum)
{
    if (number == 0) 
    {
        Console.WriteLine(sum);
        return;
    }    
    sum = sum + number % 10;
    number = number / 10;
    SumDigitInNumber(number, sum);
}

//Receiving a namber from the user:
int DataEntyNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Program:
int number = DataEntyNumber("Введите число: ");
int sum = 0;
SumDigitInNumber(number, sum);


