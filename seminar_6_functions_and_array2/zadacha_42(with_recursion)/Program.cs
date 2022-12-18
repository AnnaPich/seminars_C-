//Задача 42: 
//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

Console.Clear();

void GetBinareView (int numb)
{
    if(numb == 0) return;
    GetBinareView(numb/2);
    System.Console.Write(numb % 2); //вывод с конца (с последнего значения), обратить внимание
}


int DataEntryNumber(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}


//Программа:

int number = DataEntryNumber("введите число: ");
GetBinareView (number);