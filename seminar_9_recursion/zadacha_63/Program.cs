//Задача 63:
//Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5" 


//Print numbers:
void PrintNumbers(int number)
{
    if (number == 0) return;
    PrintNumbers(number - 1);
    Console.Write(number + ", ");
}

//Receiving a namber from the user:
int DataEntyNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Program:
int number = DataEntyNumber("Введите число N:");
PrintNumbers(number);