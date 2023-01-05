//Задача 65:
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
//в промежутке от M до N.
//M = 1; N = 5 -> 1, 2, 3, 4, 5


void PrintNumbers(int numberM, int numberN)
{
    if (numberM == numberN + 1) return;
    Console.Write(numberM + ", ");
    PrintNumbers(numberM + 1, numberN);
}


//Receiving a namber from the user:
int DataEntyNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Program:
int numberM = DataEntyNumber("Введите число M: ");
int numberN = DataEntyNumber("Введите число N: ");

if (numberN > numberM)
{
    PrintNumbers(numberM, numberN);
}
else Console.WriteLine("Ошибка! Число N должно быть больше числа M");

