//Задача 24:
//Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А.

int ResultSum (int digitA)
{
    int sum = 0;
    for (int i = 1; i <= digitA; i++)
    {
        sum = sum + i;
    }
    return sum;
}


int DataEntryA (string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}   

//Программа:

Console.Clear();

int digitA = DataEntryA ("Введите число А: ");
int result = ResultSum(digitA); // Цикл суммы цифр от 1 до А 
Console.Write(digitA +"-> " + result);