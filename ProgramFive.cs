//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве. //[345, 897, 568, 234] -> 2          
   /*
   int[] CreateRandomArray(int size, int minValue, int maxValue)
   {
       int[] array = new int[size];              
   
       for (int i = 0; i < size; i++)
       {
           array[i] = new Random().Next(minValue, maxValue + 1);
       }
       return array;              
   }

   
   void WriteArray(int[] array)
   {
       for (int i = 0; i < array.Length; i++)
       {
           Console.Write(array[i] + " ");
       }
       Console.WriteLine();
   }

   int EventNum(int[] array)
   {
       int count = 0;
       for (int i = 0; i < array.Length; i++)
       {
           if (array[i] % 2 == 0) count++;
       }
       return count;
   }

   bool ValidateMinMaxValue(int minValue, int maxValue)
   {
       if (minValue < 100 && maxValue > 1000)
       {
           Console.WriteLine("Array should contain only tree digit numbers. Wrong min and/or max volumes");
           return false;
       }
       return true;
   }

   Console.Write("Enter a length of an array: ");
   int length = Convert.ToInt32(Console.ReadLine());
   Console.Write("Enter the min possible value: ");
   int minValue = Convert.ToInt32(Console.ReadLine());
   Console.Write("Enter the max possible value: ");
   int maxValue = Convert.ToInt32(Console.ReadLine());

   if (ValidateMinMaxValue(minValue, maxValue))
   {
       int[] myArray = CreateRandomArray(length, minValue, maxValue);
       WriteArray(myArray);
       Console.WriteLine("Quantity of even numbers is " + EventNum(myArray));
   }
   */
   //Задача 36: Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях. //[3, 7, 23, 12] -> 19   //[-4, -6, 89, 6]-> 0
      /*
      int[] CreateRandomArray(int size, int minValue, int maxValue)
   {
       int[] array = new int[size];
       for (int i = 0; i < size; i++)
       {
           array[i] = new Random().Next(minValue, maxValue + 1);
       }
       return array;
   }

   void WriteArray(int[] array)
   {
       for (int i = 0; i < array.Length; i++)
       {
           Console.Write(array[i] + " ");
       }
       Console.WriteLine();
   }

   int SumOddPositions (int[] array)
   {
       int sum = 0;
       for (int i = 0; i < array.Length; i +=2) sum +=array[i];
       return sum;
   }

   Console.Write("Enter a length of an array: ");
   int length = Convert.ToInt32(Console.ReadLine());
   Console.Write("Enter the min possible value: ");
   int minValue = Convert.ToInt32(Console.ReadLine());
   Console.Write("Enter the max possible value: ");
   int maxValue = Convert.ToInt32(Console.ReadLine());


   int[] myArray = CreateRandomArray(length, minValue, maxValue);
   WriteArray(myArray);
   Console.WriteLine(SumOddPositions(myArray));
   */

   //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. // Random
   

  Console.Write("Enter a length of an array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

void CreateRandomArray(int size)
{
    Random MyArray = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = MyArray.NextDouble();
        Console.Write($"{array[i]:F2} ");  //выводим массив с округлением до двух знаков
    }  
    Console.WriteLine();   
}


CreateRandomArray(size); //выводим массив на консоль

double Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(max < array[i])   //определяем максимальный элемент в массиве
            max = array[i];
        if(min > array[i])   //определяем минимальный элемент в массиве
            min = array[i];
    }
    return max - min;   //выводим их разность
}
Console.WriteLine($"Difference between maximum and minimum: {Difference(array):F2}");
