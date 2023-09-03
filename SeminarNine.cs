//Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
string PrintNumer(int num, string res)
{
    if (num == 1)
    {
        res = '1' + res ;
        return res;
    }
    else
    {
        res = num + " " + res;
        return PrintNumer(num - 1, res);
    }
}
string result = "";

Console.Write("Input the number: ");
int number = Convert.ToInt32(Console.ReadLine());
result = PrintNumer(number, result);
Console.WriteLine(result);
*/

//Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
int PowerAB(int a, int b,)
{
 if()
 {
        return 1;
 }   
 else
 {
    return a * PowerAB(a,b - 1);
 }
}
Console.WriteLine(PowerAB(5,3));



// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
