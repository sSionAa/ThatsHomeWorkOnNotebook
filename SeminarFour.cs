// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int Summ(int a)
{
    int sum = 0;
    for (int i = 1; i <= a ; i++)
    {
    sum += i;
    }
    return sum;
}


Console.Write("input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Total sum: " + Summ(number));

*/



// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*
int DigitCounter(int n)
{
    int totalCount = 0;
    while(n > 0) 
    {
        n /= 10;
        ++totalCount;
    }
    return totalCount;
}

Console.Write("input number: ");
int digitNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Total digit count: " + DigitCounter(digitNumber));

*/

// Напишите программу, которая принимает на вход число N и выдаёт произведение нечетных чисел от 1 до N.

/*
int Product(int n)
{
    int product = 1;
    for (int i = 0; i <= n ; i++)
    {
    product = i % 2 == 0 ? product : product *= i;
    }
    return product;
}
Console.Write("input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Total product: " + Product(number));
*/

// Method generation array
/*


int[] CreateRandomArray(int size, int minValue , int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; ++i )
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posiible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);
*/