//Задача 69:
//Напишите программу, которая на вход принимает
//два числа А и В, и возводит число А в целую степень В с помощью рекурсии.


//Exponentiation number A in numer B:
void NumberAExpNamberB(int numberFirst, int numberSecond, int count, int digit)
{
    if(count == numberSecond)
    {
        Console.WriteLine($"Число {numberFirst} в степени {numberSecond} равно " + digit);
        return;
    }
    digit *= numberFirst;
    count ++;
    NumberAExpNamberB(numberFirst, numberSecond, count, digit);
}

//Receiving a namber from the user:
int DataEntyNumber(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Program:
int numberFirst = DataEntyNumber("Введите число А: ");
int numberSecond = DataEntyNumber("Введите число B: ");

int count = 1;
int digit = numberFirst;
NumberAExpNamberB(numberFirst, numberSecond, count, digit);