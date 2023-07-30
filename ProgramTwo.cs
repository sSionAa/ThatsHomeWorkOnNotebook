/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
 на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

Repeat:
int number = WriteWait("Пожалуйста, введите трёхзначное число: ");

if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ошиблись в количестве цифр!");
    goto Repeat;
}

Console.WriteLine($"В введённом числе {number} вторая цифра: {number / 10 % 10}");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).
645 -> 5
78 -> третьей цифры нет
32679 -> 6

int WriteWait(string outLine)
{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

bool CheсkDigNum(int inNum)

{
    if (inNum < 100)
    {
        Console.WriteLine($"В числе {inNum} третья цифра отсутствует.");
        return false;
    }
    return true;
}

int ThirdDigit(int inNum)

{
    while (inNum >= 1000)
    {
        inNum /= 10;
    }
    return inNum % 10;
}

int number = WriteWait("Пожалуйста, введите число: ");

if (CheсkDigNum(number))

{
    Console.WriteLine($"В числе {number} третья цифра {ThirdDigit(number)}.");
}
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

int WriteWait(string outLine)

{
    Console.Write(outLine);
    int inNumber = Convert.ToInt32(Console.ReadLine());
    return inNumber;
}

bool Weekend(int digit)

{
    if (digit < 6)
    {
        return false;
    }
    return true;
}

Repeat:
int day = WriteWait("Введите день недели от 1 до 7: ");

if (day < 1 || day > 7)
{
    Console.WriteLine("Вы ошиблись с цифрами.");
    goto Repeat;
}

if (Weekend(day))

{
    Console.WriteLine("Сегодня выходной! Работать вредно.");
}
else
{
    Console.WriteLine("Вам на работу.");
}
*/
