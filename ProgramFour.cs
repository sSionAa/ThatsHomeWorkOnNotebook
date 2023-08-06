// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int Prompt(string message)        
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int Degree(int number1, int number2)
{
    int work = 1;
    for (int i = 0; i < number2; i++)
    {
        work *= number1;
    }
    return work;
}
bool RealFactor(int number2)
{
    if (number2 < 0)
    {
        System.Console.Write("enter a number greater than zero!");
        return false;
    }
    return true;
}   
int number1 = Prompt("input a number1: ");
int number2 = Prompt("input a number2: ");
System.Console.Write($"{number1} to the extent {number2} = {Degree(number1, number2)}");
*/
// 27.Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
/*
int Prompt(string message)          
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int Summa(int number)
{
    int result = 0;
    while (number > 0)          // или можно for (;number > 0;)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
int number = Prompt("input a number: ");
System.Console.Write($"summa all numbers {number} = {Summa(number)}");
*/
// 29. Напишите программу, которая задаёт массив из m элементов 
// и выводит их на экран.
// Ввод элементов пользователем.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size]; 
    for(int i =0; i < size; i++)  
    {
        Console.Write($"Input a {i} value of an array: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
void WriteArray(int[] array)   
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");   
}
Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(length);
WriteArray(myArray);
*/
