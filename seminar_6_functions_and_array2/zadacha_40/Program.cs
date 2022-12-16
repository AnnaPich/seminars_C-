//Задача 40: 
//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.Clear();

bool CheckTriangle(int one, int two, int three)
{
    bool resalt = false;
    if(one < two + three && two < one + three && three < one + two) resalt = true;
    return resalt;
}



//Прием числа:
int DataEntryNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//программа:

int numberOne = DataEntryNumber("Введите число 1: ");
int numberTwo = DataEntryNumber("Введите число 2: ");
int numberThree = DataEntryNumber("Введите число 3: ");

bool result = CheckTriangle(numberOne, numberTwo, numberThree);
if (result == true) Console.WriteLine("Треугольник может существовать");
else {Console.WriteLine("Треугольник существовать не может");}
