/*
int num, result;

Console.Write("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

result = num * num;

Console.WriteLine("Result is " + result);
*/



/* DZ*/

/*
int num1, num2;

Console.WriteLine("Введите число: ");

num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

num2 = Convert.ToInt32(Console.ReadLine());

if(num1 < num2)
{
    Console.WriteLine("Максимальное число: " + num2);
}
else
{
    Console.WriteLine("Максимальное число: " + num1);
}

*/



/*
int num1, num2, num3, max;

Console.WriteLine("Введите поочерёдно три числа: ");
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;
if(num1 < num2) max = num2;
if(num2 < num3) max = num3;

Console.WriteLine("Максимальное число: " + max);
*/

/*
int num, current;

Console.WriteLine("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
current = num / 2;
current ++;

if(current == 1) Console.WriteLine("Нечетное число: ");
else
{
   Console.WriteLine("Четное число: "); 
}
*/



/*int N, current;

Console.WriteLine("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());

while(N - 1 == 0)
{
    N = N - 1;
    Console.WriteLine(" N ");
}
current = N / 2;
current ++;
*/





/*ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 2*/

/*
int CutNumer()
{
    int num = new Random().Next(100,999);
Console.WriteLine($"Выбранное число {num}");

int sot = num / 10;
int result = sot % 10;
return result;
}
*/



/*
int CutNotFhree ()
{
    int num, result;
    Console.WriteLine("Введите любое целое число: ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num < 100) Console.WriteLine("Третья цифра отсутствует");
    if (num > 100);
    result = num / 10;
    return result;
}
*/


/*
int WeekDays ()
{
    int num, result;
    Console.WriteLine("Введите цифру дня недели от 1 до 7: ");
    num = Convert.ToInt32(Console.ReadLine());
    if (num >= 6)
    {
    return True;
    }
    else
    {
    return False;
    }

}
*/


ДЗ к СЕМИНАРУ 

1 ЗАДАЧА:

/*
int FindPolindrom ()
{
    int num;
    Console.WriteLine ("Введите пятизначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
    
    int num5 = num % 10;
    int num4 = num % 100;
    int num2 = num % 1000;
    int num1 = num % 10000;

        if(num1 == num5 && num2 == num4)
        {
        Console.WriteLine("True");
        }
         else
        {
        Console.WriteLine("False");
        }
}
FindPolindrom(num);
*/

2 ЗАДАЧА:

/*
double FindLenght(double xA, double yA, double zA, double xB, double yB, double zB)
{
    Convert.ToDouble()
    return Math.Pow((xA - xB),2) + Math.Pow((yA - yB),2) + Math.Pow((zA - zB),2);
}
*/

3 ЗАДАЧА:

/*
void Cube(int num)
{
    int current = 1;
    while (current <= num)
    {
        Console.Write((current * current * current) + " ");
        current++;
    }
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Cube(num);
*/

/*
ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 4

ЗАДАЧА 1:

int Stepen (int a, int b);
int current = 1; current ++;
while (current <= b)
{
Console.WriteLine(a * a);
}

Думаю, задача решена неверно
*/


/*
ЗАДАЧА 2:

int size = 8;
int[] array = new int[size];

for (int i = 0; i < size; i = i + 1)
{
    array[i] = new Random().Next(0,1000);
}
for (int i = 0; i < size; i = i + 1)
{
    Console.WriteLine(array[i] + " ");
}
*/








/*ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 5
*/
/*ЗАДАЧА 1:*/

/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i ++)
    {
        newArray[i] = new Random().Next(min = 100, max = 1000);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

int FindCountEvenSum(int[] array,int min, int max)
{
    int count = 0;
    for( int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count ++;
    }
    return count;
}
*/

/*ЗАДАЧА 2:*/

/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i ++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

int FindSumNotEvenNum(int[] array,int min, int max, int step = 2)
{
    int sum = 0;
    for( int i = 1; i < array.Length; i + step)
    {
        if(array[i] % 2 == 1) sum ++;
    }
    return sum;
}
*/

/*ЗАДАЧА 3:*/

/*double[] CreateRandomDoubleArray(int size)
{
    double[] newArray = new double[size];
    for(int i = 0; i < size; i ++)
    {
        newArray[i] = new Random().NextDouble();
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

int FindвDifMaxMin(double[] array, double min, double max, double result)
{
    double minNumber = array[i];
    double maxNumber = array[i];

    for( int i = 0; i < array.Length; i ++)
    {
        if(array[i] < minNumber)
        {
            minNumber = array[i];
        }
        if(array[i] < maxNumber)
        {
            maxNumber = array[i];
        }
        
    }
    Console.WriteLine(maxNumber);
    Console.WriteLine(minNumber);

    double maxNumber - double minNumber = result;
    return resalt;
}
*/



/*

ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 6

ЗАДАЧА 1:

int FindNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine ("Введите любое количество целых чисел: ");
int array = Convert.ToInt32(Console.ReadLine());



ЗАДАЧА 2:

int ArrayCopy(int[] FirsArray, int[] SecondArray, int size)
{
    int[] FirstArray = new int[size];
    for(int i = 0; i <size; i ++);
    int[] SecondArray = new int[size];
    for(int j = 0; j <size; j ++);
    {
        [j] == [i]; if ++; j ++;
    }
    return SecondArray;

}
*/


/*ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 7

ЗАДАЧА 1:
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

double[,] CreateTwoArray(double n, double m, double min, double max)
{
double[,] newMatrix = new double (n,m);
for(double i = 0; i < n; i++)
{
    for(double j = 0; j < m; j++)
    {
        newMatrix[i,j] = new Random().NextDouble(min, max + 1);
        Console.Write(newMatrix[i,j] + " ")
    }
    Console.WriteLine();
}
return newMatrix;
}


ЗАДАЧА 2:
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] NewMatrix(int a, int b)
{
    int[,] newMatrix = new int[a,b];
    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            if
            {
                [i] < a && [j] < b;
            }
            else
            {
                return Console.WriteLine (" Такого элемента нет ")
            }
        }
    Console.WriteLine();
    }
    return newMatrix;
}


ЗАДАЧА 3:
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateArrayIntegSumСolumns(int a, int b)
{

int[,] newMatrix = new int (a,b);
 for(int i = 0; i < a; i++)
 {
    for(int j = 0; j < a; j++)
    {
      while j < b
      (for(i = 0; i < array.Get.Length; i++)) / a;
    }
 }
}
